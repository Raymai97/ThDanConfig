using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace MaiSoft
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            bool hasSegoeUI = false;
            var installedFonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (var item in installedFonts.Families)
            {
                if (item.Name == "Segoe UI") hasSegoeUI = true;
            }
            if (!hasSegoeUI) this.Font = new Font("Tahoma", 8);
            this.Icon = Program.ExeIcon;
        }

        // Field
        private const string PROGRAM_NAME = "Touhou Danmaku Game Config Editor";
        private string _openedFile;
        private th06 th06 = new th06();
        private th07 th07 = new th07();
        private th08 th08 = new th08();
        private th09 th09 = new th09();
        private th095 th095 = new th095();
        private th10 th10 = new th10();
        private th11 th11 = new th11();
        private th12 th12 = new th12();
        private th125 th125 = new th125();
        private th128 th128 = new th128();
        private th13 th13 = new th13();
        private th14 th14 = new th14();
        private th143 th143 = new th143();
        private th15 th15 = new th15();
        private th16 th16 = new th16();

        // Enum
        private enum thGame
        {
            th06,
            th07,
            th08,
            th09,
            th095,
            th10,
            th11,
            th12,
            th125,
            th128,
            th13,
            th14,
            th143,
            th15,
            th16
        }


        // Property
        private thGame selectedGame
        {
            get
            {
                return (thGame)cmbGame.SelectedIndex;
            }
            set
            {
                cmbGame.SelectedIndex = (int)value;
                _openedFile = null;
                AutoTitle();
            }
        }

        private string openedFile
        {
            get
            {
                return _openedFile;
            }

            set
            {
                _openedFile = value;
                AutoTitle();
            }
        }

        // Method
        private void Auto()
        {
            thGame game = selectedGame;
            // BGM & SE
            rdoMIDI.Enabled = (game <= thGame.th09);
            if (rdoMIDI.Checked & !rdoMIDI.Enabled) rdoWAV.Checked = true;
            grpBGMvol.Enabled = (game >= thGame.th08);
            grpSEvol.Enabled = (game >= thGame.th08);
            // Display & InputLat & WinPos
            AutoDisp();
            grpLatency.Enabled = (game >= thGame.th11);
            grpWinPos.Enabled = (game >= thGame.th11);
            // Default Diffi & Initial Bomb/Life
            grpDifficulty.Enabled = (game <= thGame.th09);
            grpBomb.Enabled = (game == thGame.th06);
            grpLife.Enabled = (game <= thGame.th09);
            numLife.Minimum = (game <= thGame.th08 ? 1 : 3);
            numLife.Maximum = (game == thGame.th08 ? 7 : 5);
            // OLDFLAGS & MISC
            chkClearBackbuffer.Enabled = (game < thGame.th09);
            chkForce60frames.Enabled = (game < thGame.th09);
            chkFullyRedraw.Enabled = (game == thGame.th07 | game == thGame.th08);
            chkLoadBGMintoRAM.Enabled = (game < thGame.th10 & game >= thGame.th07);
            chkMinGraphics.Enabled = (game < thGame.th09);
            chkNoColorCompo.Enabled = (game < thGame.th09);
            chkNoDepthTest.Enabled = (game < thGame.th09);
            chkNoFog.Enabled = (game < thGame.th10);
            chkNoTrialMenuColor.Enabled = (game == thGame.th06);
            chkNoVertexBuffer.Enabled = (game < thGame.th09);
            chkNoVerticalSync.Enabled = (game < thGame.th10 & game >= thGame.th07);
            chkSlowMode.Enabled = (game == thGame.th07 | game == thGame.th08);
            chkUse16bitTextures.Enabled = (game < thGame.th10);
            chkUseLesserGS.Enabled = (game < thGame.th09);
            chkUseRefRasterizer.Enabled = (game < thGame.th10);
            tab_misc.Enabled = (game <= thGame.th095);
            tab_th09ctrl.Enabled = (game == thGame.th09);
            // FLAGS
            chkFaithMeterNearPlayer.Enabled = (game == thGame.th10);
            chkFocusShot.Enabled = (game == thGame.th07 | game == thGame.th08 | game >= thGame.th10);
        }

        private void AutoDisp()
        {
            thGame game = selectedGame;
            chkAskAtStartup.Enabled = (game >= thGame.th10);
            if (game >= thGame.th14 |
                (game >= thGame.th11 & !chkFullscreen.Checked))
            {
                rdoMedRes.Enabled = true;
                rdoHighRes.Enabled = true;
            }
            else
            {
                rdoLowRes.Checked = true;
                rdoMedRes.Enabled = false;
                rdoHighRes.Enabled = false;
            }
        }

        private void AutoTitle()
        {
            this.Text = PROGRAM_NAME + " - " +
                (openedFile == null ? "Unsaved" : openedFile);
        }

        private byte[] defCfgOf(thGame game)
        {
            switch (game)
            {
                case thGame.th06:
                    return Properties.Resources.def_th06_cfg;
                case thGame.th07:
                    return Properties.Resources.def_th07_cfg;
                case thGame.th08:
                    return Properties.Resources.def_th08_cfg;
                case thGame.th09:
                    return Properties.Resources.def_th09_cfg;
                case thGame.th095:
                    return Properties.Resources.def_th095_cfg;
                case thGame.th10:
                    return Properties.Resources.def_th10_cfg;
                case thGame.th11:
                    return Properties.Resources.def_th11_cfg;
                case thGame.th12:
                    return Properties.Resources.def_th12_cfg;
                case thGame.th125:
                    return Properties.Resources.def_th125_cfg;
                case thGame.th128:
                    return Properties.Resources.def_th128_cfg;
                case thGame.th13:
                    return Properties.Resources.def_th13_cfg;
                case thGame.th14:
                    return Properties.Resources.def_th14_cfg;
                case thGame.th143:
                    return Properties.Resources.def_th143_cfg;
                case thGame.th15:
                    return Properties.Resources.def_th15_cfg;
                case thGame.th16:
                    return Properties.Resources.def_th16_cfg;
            }
            throw new NotImplementedException();
        }

        private void OpenCfg(string filePath)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { OpenCfg(filePath); });
                return;
            }
            try
            {
                using (var s = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (s.Length > 1024) throw new InvalidDataException 
                            ("File size is too big, impossible to be Touhou Game Config file.");
                    using (var reader = new BinaryReader(s))
                    {
                        byte[] data = reader.ReadBytes((int)s.Length);
                        if (th16.validate(data))
                        {
                            selectedGame = thGame.th16; CfgToUI(th16, data);
                        }
                        else if (th15.validate(data))
                        {
                            selectedGame = thGame.th15; CfgToUI(th15, data);
                        }
                        else if (th143.validate(data))
                        {
                            selectedGame = thGame.th143; CfgToUI(th143, data);
                        }
                        else if (th14.validate(data))
                        {
                            selectedGame = thGame.th14; CfgToUI(th14, data);
                        }
                        else if (th13.validate(data))
                        {
                            selectedGame = thGame.th13; CfgToUI(th13, data);
                        }
                        else if (th128.validate(data))
                        {
                            selectedGame = thGame.th128; CfgToUI(th128, data);
                        }
                        else if (th125.validate(data))
                        {
                            selectedGame = thGame.th125; CfgToUI(th125, data);
                        }
                        else if (th12.validate(data))
                        {
                            selectedGame = thGame.th12; CfgToUI(th12, data);
                        }
                        else if (th11.validate(data))
                        {
                            selectedGame = thGame.th11; CfgToUI(th11, data);
                        }
                        else if (th10.validate(data))
                        {
                            selectedGame = thGame.th10; CfgToUI(th10, data);
                        }
                        else if (th095.validate(data))
                        {
                            selectedGame = thGame.th095; CfgToUI(th095, data);
                        }
                        else if (th09.validate(data))
                        {
                            selectedGame = thGame.th09; CfgToUI(th09, data);
                        }
                        else if (th08.validate(data))
                        {
                            selectedGame = thGame.th08; CfgToUI(th08, data);
                        }
                        else if (th07.validate(data))
                        {
                            selectedGame = thGame.th07; CfgToUI(th07, data);
                        }
                        else if (th06.validate(data))
                        {
                            selectedGame = thGame.th06; CfgToUI(th06, data);
                        }
                        else
                        {
                            throw new InvalidDataException
                                ("ThDanConfig can't recognize the data of this file!\n"
                                + "Only cfg files from TH06 to TH16 are supported now. ");
                        }
                    }
                }
                openedFile = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + filePath,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCfg(string filePath)
        {
            using (var s = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var reader = new BinaryReader(s))
                {
                    byte[] data = reader.ReadBytes((int)s.Length);
                    thCom th;
                    switch (selectedGame)
                    {
                        case thGame.th06:
                            th = th06; break;
                        case thGame.th07:
                            th = th07; break;
                        case thGame.th08:
                            th = th08; break;
                        case thGame.th09:
                            th = th09; break;
                        case thGame.th095:
                            th = th095; break;
                        case thGame.th10:
                            th = th10; break;
                        case thGame.th11:
                            th = th11; break;
                        case thGame.th12:
                            th = th12; break;
                        case thGame.th125:
                            th = th125; break;
                        case thGame.th128:
                            th = th128; break;
                        case thGame.th13:
                            th = th13; break;
                        case thGame.th14:
                            th = th14; break;
                        case thGame.th143:
                            th = th143; break;
                        case thGame.th15:
                            th = th15; break;
                        case thGame.th16:
                            th = th16; break;
                        default: throw new NotImplementedException();
                    }
                    if (!th.validate(data)) data = defCfgOf(selectedGame);
                    UIToCfg(th, ref data);
                    using (var writer = new BinaryWriter(s))
                    {
                        s.Seek(0, SeekOrigin.Begin);
                        writer.Write(data);
                    }
                }
            }
        }

        private void CfgToUI(thCom th, byte[] data)
        {
            th.inData(data);
            // Game-specific
            if (th is th06)
            {
                chkNoTrialMenuColor.Checked = ((th06)th).dontUseTrialVerMenuColor;
                numBomb.Value = ((th06)th).initialBomb;
            }
            if (th is th09)
            {
                switch (((th09)th).controlType_1P)
                {
                    case thCom.CONTROL_TYPE.GAMEPAD1:
                        rdoTh09_1P_pad1.Checked = true; break;
                    case thCom.CONTROL_TYPE.GAMEPAD2:
                        rdoTh09_1P_pad2.Checked = true; break;
                    case thCom.CONTROL_TYPE.KEYBOARD_ALL:
                        rdoTh09_1P_all.Checked = true; break;
                    case thCom.CONTROL_TYPE.KEYBOARD_LEFT:
                        rdoTh09_1P_left.Checked = true; break;
                    case thCom.CONTROL_TYPE.KEYBOARD_RIGHT:
                        rdoTh09_1P_right.Checked = true; break;
                }
                (((th09)th).chargeViaShift_1P ?
                    rdoTh09_1P_charge : rdoTh09_1P_slow ).Checked = true;
                switch (((th09)th).controlType_2P)
                {
                    case thCom.CONTROL_TYPE.GAMEPAD1:
                        rdoTh09_2P_pad1.Checked = true; break;
                    case thCom.CONTROL_TYPE.GAMEPAD2:
                        rdoTh09_2P_pad2.Checked = true; break;
                    case thCom.CONTROL_TYPE.KEYBOARD_ALL:
                        rdoTh09_2P_all.Checked = true; break;
                    case thCom.CONTROL_TYPE.KEYBOARD_LEFT:
                        rdoTh09_2P_left.Checked = true; break;
                    case thCom.CONTROL_TYPE.KEYBOARD_RIGHT:
                        rdoTh09_2P_right.Checked = true; break;
                }
                (((th09)th).chargeViaShift_2P ?
                    rdoTh09_2P_charge : rdoTh09_2P_slow).Checked = true;
            }
            if (th is th10)
            {
                chkFaithMeterNearPlayer.Checked = ((th10)th).showFaithMeterNearPlayer;
            }
            // BGM & SE
            switch (th.bgmMode)
            {
                case thCom.BGM.OFF:
                    rdoNoBGM.Checked = true;
                    break;
                case thCom.BGM.WAV:
                    rdoWAV.Checked = true;
                    break;
                case thCom.BGM.MID:
                    rdoMIDI.Checked = true;
                    break;
            }
            chkSEenabled.Checked = th.seEnabled;
            if (!(th is th06 | th is th07))
            {
                numBGMvol.Value = th.bgmVol;
                numSEvol.Value = th.seVol;
            }
            // Color & FPS & Joypad sen
            (th.color == thCom.COLOR._32BIT ?
                rdo32bitColor : rdo16bitColor).Checked = true;
            switch (th.fps)
            {
                case thCom.FPS._60FPS:
                    rdo60fps.Checked = true;
                    break;
                case thCom.FPS._30FPS:
                    rdo30fps.Checked = true;
                    break;
                case thCom.FPS._20FPS:
                    rdo20fps.Checked = true;
                    break;
            }
            numJoySen.Value = th.joypadSen;
            // Display & InputLat & WinPos
            if (th is thCom_th11)
            {
                var _11 = (thCom_th11)th;
                // TH14++ use DISP3 instead
                if (th is th14)
                {
                    var _14 = (th14)th;
                    switch (_14.display)
                    {
                        case thCom.DISP3.LOW:
                            chkFullscreen.Checked = true;
                            rdoLowRes.Checked = true;
                            break;
                        case thCom.DISP3.MED:
                            chkFullscreen.Checked = true;
                            rdoMedRes.Checked = true;
                            break;
                        case thCom.DISP3.HIGH:
                            chkFullscreen.Checked = true;
                            rdoHighRes.Checked = true;
                            break;
                        case thCom.DISP3.LOW_WIN:
                            chkFullscreen.Checked = false;
                            rdoLowRes.Checked = true;
                            break;
                        case thCom.DISP3.MED_WIN:
                            chkFullscreen.Checked = false;
                            rdoMedRes.Checked = true;
                            break;
                        case thCom.DISP3.HIGH_WIN:
                            chkFullscreen.Checked = false;
                            rdoHighRes.Checked = true;
                            break;
                    }
                }
                else
                {
                    switch (_11.display)
                    {
                        case thCom.DISP2.FULL:
                            chkFullscreen.Checked = true;
                            rdoLowRes.Checked = true;                           
                            break;
                        case thCom.DISP2.LOW_WIN:
                            chkFullscreen.Checked = false;
                            rdoLowRes.Checked = true;
                            break;
                        case thCom.DISP2.MED_WIN:
                            chkFullscreen.Checked = false;
                            rdoMedRes.Checked = true;
                            break;
                        case thCom.DISP2.HIGH_WIN:
                            chkFullscreen.Checked = false;
                            rdoHighRes.Checked = true;
                            break;
                    }
                }
                switch (_11.inputLatency)
                {
                    case thCom.INPUT_LAT.STABLE:
                        rdoStableIL.Checked = true;
                        break;
                    case thCom.INPUT_LAT.NORMAL:
                        rdoNormalIL.Checked = true;
                        break;
                    case thCom.INPUT_LAT.AUTO:
                        rdoAutoIL.Checked = true;
                        break;
                    case thCom.INPUT_LAT.FAST:
                        rdoFastIL.Checked = true;
                        break;
                }
                numWinPosX.Value = _11.winPosX;
                numWinPosY.Value = _11.winPosY;
            }
            else // th06 ~ th10
            {
                chkFullscreen.Checked = (th.display == thCom.DISP.FULL);
            }
            // Default Diffi & Initial Life
            if (th is thCom_oldGen & !(th is th095))
            {
                var _og = (thCom_oldGen)th;
                switch (_og.defDifficulty)
                {
                    case thCom.DIFFICULTY.EASY:
                        rdoEasyDiffi.Checked = true;
                        break;
                    case thCom.DIFFICULTY.NORMAL:
                        rdoNormalDiffi.Checked = true;
                        break;
                    case thCom.DIFFICULTY.HARD:
                        rdoHardDiffi.Checked = true;
                        break;
                    case thCom.DIFFICULTY.LUNATIC:
                        rdoLunaticDiffi.Checked = true;
                        break;
                }
                numLife.Value = _og.initialLife;
            }
            // OLDFLAGS
            if (th is thCom_th06_07_08)
            {
                var _678 = (thCom_th06_07_08)th;
                chkClearBackbuffer.Checked = _678.clearBackbufferOnRefresh;
                chkForce60frames.Checked = _678.force60frames;
                chkNoColorCompo.Checked = _678.noColorCompoToTextures;
                chkNoDepthTest.Checked = _678.noDepthTest;
                chkNoDirectInput.Checked = _678.noDirectInputForJoypad;
                chkNoFog.Checked = _678.noFog;
                chkNoVertexBuffer.Checked = _678.noVertexBuffer;
                chkMinGraphics.Checked = _678.showMinGraphics;
                chkUse16bitTextures.Checked = _678.use16bitTextures;
                chkUseLesserGS.Checked = _678.useLesserGouraudShading;
                chkUseRefRasterizer.Checked = _678.useRefRasterizer;
                if (th is thCom_th07_th08)
                {
                    var _78 = (thCom_th07_th08)th;
                    chkFocusShot.Checked = _78.focusWhileShot;
                    chkFullyRedraw.Checked = _78.fullyRedrawOnRefresh;
                    chkLoadBGMintoRAM.Checked = _78.loadBGMintoRAM;
                    chkNoVerticalSync.Checked = _78.noVerticalSync;
                    chkSlowMode.Checked = _78.slowMode;
                }
            }
            if (th is thCom_th09_th095)
            {
                var _09x = (thCom_th09_th095)th;
                chkLoadBGMintoRAM.Checked = _09x.loadBGMintoRAM;
                chkNoDirectInput.Checked = _09x.noDirectInputForJoypad;
                chkNoFog.Checked = _09x.noFog;
                chkNoVerticalSync.Checked = _09x.noVerticalSync;
                chkUse16bitTextures.Checked = _09x.use16bitTextures;
                chkUseRefRasterizer.Checked = _09x.useRefRasterizer;
            }
            // FLAGS
            if (th is thCom_th10)
            {
                var _10 = (thCom_th10)th;
                chkAskAtStartup.Checked = _10.askAtStartup;
                chkFocusShot.Checked = _10.focusWhileShot;
                chkNoDirectInput.Checked = _10.noDirectInputForJoypad;
            }
        }

        private void UIToCfg(thCom th, ref byte[] data)
        {
            th.inData(data);
            // Game-specific
            if (th is th06)
            {
                ((th06)th).dontUseTrialVerMenuColor = chkNoTrialMenuColor.Checked;
                ((th06)th).initialBomb = (int)numBomb.Value;
            }
            if (th is th09)
            {
                ((th09)th).controlType_1P =
                    (rdoTh09_1P_pad1.Checked ? thCom.CONTROL_TYPE.GAMEPAD1 :
                    (rdoTh09_1P_pad2.Checked ? thCom.CONTROL_TYPE.GAMEPAD2 :
                    (rdoTh09_1P_all.Checked ? thCom.CONTROL_TYPE.KEYBOARD_ALL :
                    (rdoTh09_1P_left.Checked ? thCom.CONTROL_TYPE.KEYBOARD_LEFT :
                    thCom.CONTROL_TYPE.KEYBOARD_RIGHT
                    ))));
                ((th09)th).chargeViaShift_1P = rdoTh09_1P_charge.Checked;
                ((th09)th).controlType_2P =
                    (rdoTh09_2P_pad1.Checked ? thCom.CONTROL_TYPE.GAMEPAD1 :
                    (rdoTh09_2P_pad2.Checked ? thCom.CONTROL_TYPE.GAMEPAD2 :
                    (rdoTh09_2P_all.Checked ? thCom.CONTROL_TYPE.KEYBOARD_ALL :
                    (rdoTh09_2P_left.Checked ? thCom.CONTROL_TYPE.KEYBOARD_LEFT :
                    thCom.CONTROL_TYPE.KEYBOARD_RIGHT
                    ))));
                ((th09)th).chargeViaShift_2P = rdoTh09_2P_charge.Checked;
            }
            if (th is th10)
            {
                ((th10)th).showFaithMeterNearPlayer = chkFaithMeterNearPlayer.Checked;
            }
            // BGM & SE
            th.bgmMode = (rdoNoBGM.Checked ? thCom.BGM.OFF : (
                rdoWAV.Checked ? thCom.BGM.WAV : thCom.BGM.MID
                ));
            th.seEnabled = chkSEenabled.Checked;
            if (!(th is th06 | th is th07))
            {
                th.bgmVol = (int)numBGMvol.Value;
                th.seVol = (int)numSEvol.Value;
            }
            // Color & FPS & Joypad sen
            th.color = (rdo32bitColor.Checked ? thCom.COLOR._32BIT : thCom.COLOR._16BIT);
            th.fps = (rdo60fps.Checked ? thCom.FPS._60FPS : (
                rdo30fps.Checked ? thCom.FPS._30FPS : thCom.FPS._20FPS
                ));
            th.joypadSen = (int)numJoySen.Value;
            // Display & InputLat & WinPos
            if (th is thCom_th11)
            {
                var _11 = (thCom_th11)th;
                // TH14++ use DISP3 instead
                if (th is th14)
                {
                    var _14 = (th14)th;
                    if (chkFullscreen.Checked)
                    {
                        _14.display = (rdoLowRes.Checked ? thCom.DISP3.LOW : (
                            rdoMedRes.Checked ? thCom.DISP3.MED : thCom.DISP3.HIGH
                            ));
                    }
                    else
                    {
                        _14.display = (rdoLowRes.Checked ? thCom.DISP3.LOW_WIN : (
                            rdoMedRes.Checked ? thCom.DISP3.MED_WIN : thCom.DISP3.HIGH_WIN
                            ));
                    }
                }
                else
                {
                    if (chkFullscreen.Checked)
                    {
                        _11.display = thCom.DISP2.FULL;
                    }
                    else
                    {
                        _11.display = (rdoLowRes.Checked ? thCom.DISP2.LOW_WIN : (
                            rdoMedRes.Checked ? thCom.DISP2.MED_WIN : thCom.DISP2.HIGH_WIN
                            ));
                    }
                }
                _11.inputLatency = (rdoStableIL.Checked ? thCom.INPUT_LAT.STABLE : (
                    rdoNormalIL.Checked ? thCom.INPUT_LAT.NORMAL : (
                    rdoAutoIL.Checked ? thCom.INPUT_LAT.AUTO : thCom.INPUT_LAT.FAST
                    )));
                _11.winPosX = (int)numWinPosX.Value;
                _11.winPosY = (int)numWinPosY.Value;
            }
            else // th06 ~ th10
            {
                th.display = (chkFullscreen.Checked ? thCom.DISP.FULL : thCom.DISP.WIN); 
            }
            // Default Diffi & Initial Life
            if (th is thCom_oldGen & !(th is th095))
            {
                var _og = (thCom_oldGen)th;
                _og.defDifficulty = (rdoEasyDiffi.Checked ? thCom.DIFFICULTY.EASY : (
                    rdoNormalDiffi.Checked ? thCom.DIFFICULTY.NORMAL : (
                    rdoHardDiffi.Checked ? thCom.DIFFICULTY.HARD : thCom.DIFFICULTY.LUNATIC
                    )));
                _og.initialLife = (int)numLife.Value;
            }
            // OLDFLAGS
            if (th is thCom_th06_07_08)
            {
                var _678 = (thCom_th06_07_08)th;
                _678.clearBackbufferOnRefresh = chkClearBackbuffer.Checked;
                _678.force60frames = chkForce60frames.Checked;
                _678.noColorCompoToTextures = chkNoColorCompo.Checked;
                _678.noDepthTest = chkNoDepthTest.Checked;
                _678.noDirectInputForJoypad = chkNoDirectInput.Checked;
                _678.noFog = chkNoFog.Checked;
                _678.noVertexBuffer = chkNoVertexBuffer.Checked;
                _678.showMinGraphics = chkMinGraphics.Checked;
                _678.use16bitTextures = chkUse16bitTextures.Checked;
                _678.useLesserGouraudShading = chkUseLesserGS.Checked;
                _678.useRefRasterizer = chkUseRefRasterizer.Checked;
                if (th is thCom_th07_th08)
                {
                    var _78 = (thCom_th07_th08)th;
                    _78.focusWhileShot = chkFocusShot.Checked;
                    _78.fullyRedrawOnRefresh = chkFullyRedraw.Checked;
                    _78.loadBGMintoRAM = chkLoadBGMintoRAM.Checked;
                    _78.noVerticalSync = chkNoVerticalSync.Checked;
                    _78.slowMode = chkSlowMode.Checked;
                }
            }
            if (th is thCom_th09_th095)
            {
                var _09x = (thCom_th09_th095)th;
                _09x.loadBGMintoRAM = chkLoadBGMintoRAM.Checked;
                _09x.noDirectInputForJoypad = chkNoDirectInput.Checked;
                _09x.noFog = chkNoFog.Checked;
                _09x.noVerticalSync = chkNoVerticalSync.Checked;
                _09x.use16bitTextures = chkUse16bitTextures.Checked;
                _09x.useRefRasterizer = chkUseRefRasterizer.Checked;
            }
            // FLAGS
            if (th is thCom_th10)
            {
                var _10 = (thCom_th10)th;
                _10.askAtStartup = chkAskAtStartup.Checked;
                _10.focusWhileShot = chkFocusShot.Checked;
                _10.noDirectInputForJoypad = chkNoDirectInput.Checked;
            }
            data = th.outData();
        }

        // Event handler

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            this.Activate();
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var t = new Thread((ThreadStart)delegate { OpenCfg(files[0]); });
            t.Start();
        }

        private void frmMain_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbGame.SelectedIndex = 0;
            btnRestoreDefault.PerformClick();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1) OpenCfg(args[1]);
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            openedFile = null;
            btnRestoreDefault.PerformClick();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Multiselect = false;
            ofd.Filter = "Touhou game config (*.cfg)|*.cfg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenCfg(ofd.FileName);
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (openedFile == null)
            {
                miSaveAs.PerformClick();
            }
            else
            {
                SaveCfg(openedFile);
                MessageBox.Show("Touhou game config has been saved successfully!\n\n" + openedFile
                        , "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "";
            sfd.Filter = "Touhou game config (*.cfg)|*.cfg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveCfg(sfd.FileName);
                    openedFile = sfd.FileName;
                    MessageBox.Show("Touhou game config has been saved successfully!\n\n" + openedFile
                        ,"OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto();
            openedFile = null;
        }

        private void btnPrevGame_Click(object sender, EventArgs e)
        {
            if (cmbGame.SelectedIndex > 0) cmbGame.SelectedIndex -= 1;
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            if (cmbGame.SelectedIndex < cmbGame.Items.Count - 1)
                cmbGame.SelectedIndex += 1;
        }

        private void btnRestoreDefault_Click(object sender, EventArgs e)
        {
            byte[] data = defCfgOf(selectedGame);
            switch (selectedGame)
            {
                case thGame.th06:
                    CfgToUI(th06, data); break;
                case thGame.th07:
                    CfgToUI(th07, data); break;
                case thGame.th08:
                    CfgToUI(th08, data); break;
                case thGame.th09:
                    CfgToUI(th09, data); break;
                case thGame.th095:
                    CfgToUI(th095, data); break;
                case thGame.th10:
                    CfgToUI(th10, data); break;
                case thGame.th11:
                    CfgToUI(th11, data); break;
                case thGame.th12:
                    CfgToUI(th12, data); break;
                case thGame.th125:
                    CfgToUI(th125, data); break;
                case thGame.th128:
                    CfgToUI(th128, data); break;
                case thGame.th13:
                    CfgToUI(th13, data); break;
                case thGame.th14:
                    CfgToUI(th14, data); break;
                case thGame.th143:
                    CfgToUI(th143, data); break;
                case thGame.th15:
                    CfgToUI(th15, data); break;
                default: throw new NotImplementedException();
            }
        }

        private void chkFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            AutoDisp();
        }

        private void rdoMidRes_CheckedChanged(object sender, EventArgs e)
        {
            AutoDisp();
        }

        private void rdoHighRes_CheckedChanged(object sender, EventArgs e)
        {
            AutoDisp();
        }

        private void btnResetJoypadSen_Click(object sender, EventArgs e)
        {
            numJoySen.Value = 600;
        }

        private void btnCenterWinPos_Click(object sender, EventArgs e)
        {
            using (Form frm = new Form())
            {
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                Size clientSize = new Size();
                clientSize.Width = (rdoLowRes.Checked ? 640 : (
                    rdoMedRes.Checked ? 960 : 1280
                    ));
                clientSize.Height = (rdoLowRes.Checked ? 480 : (
                    rdoMedRes.Checked ? 720 : 960
                    ));
                frm.ClientSize = clientSize;
                Size screen = Screen.PrimaryScreen.WorkingArea.Size;
                numWinPosX.Value = (screen.Width - frm.Width) / 2;
                numWinPosY.Value = (screen.Height - frm.Height) / 2;
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog(this);
        }
    }
}

function $$(id) { return document.getElementById(id); }
function $$s(id) { return $$(id).style; }
function hide(id) {
	if ('opacity' in document.body.style) { $$s(id).opacity = 0; }
	else { $$s(id).visibility = 'hidden'; }
}
function show(id) {
	if ('opacity' in document.body.style) { $$s(id).opacity = 1; }
	else { $$s(id).visibility = 'visible'; }
} 

var i = 0;

function NextImg(){
	i += 1;
	if (i > 2)  { i = 0; }
	if (i == 0) { show("img_1"); hide("img_2"); hide("img_3"); }
	if (i == 1) { hide("img_1"); show("img_2"); hide("img_3"); }
	if (i == 2) { hide("img_1"); hide("img_2"); show("img_3"); }	
}

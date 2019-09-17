let unicorn;
function setup(){
	createCanvas(1000, 1000);
	unicorn=new Unicorn();
}

function keyPressed(){
	if(key == ' '){
		unicorn.jump();
	}
}

function draw(){
	background(220);
	unicorn.show();
	unicorn.move();
}
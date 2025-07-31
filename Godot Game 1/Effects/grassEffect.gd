extends Node2D

@onready var animatedSprite = $AnimatedSprite2D



func _ready():
	animatedSprite.play("Animate")
	
func _process(delta):
	if Input.is_action_just_pressed("Attack"):
		animatedSprite.play("Animate")



func _on_animated_sprite_2d_animation_finished():
	queue_free()

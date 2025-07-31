extends "res://Collectables/collectable.gd"

@onready var animations = $AnimationPlayer

func Collect(inventory: Inventory):
	animations.play("Spin")
	await animations.animation_finished
	super(inventory)
	

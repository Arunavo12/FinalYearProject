extends Node2D

func create_grass_effect():
	var grassEffect = preload("res://Effects/grass_effect.tscn").instantiate()
	get_tree().current_scene.add_child(grassEffect)
	grassEffect.global_position = global_position

func _on_hurt_box_area_entered(area):
	create_grass_effect()
	queue_free()

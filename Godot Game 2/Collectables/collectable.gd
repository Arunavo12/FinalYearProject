extends Area2D

@export var itemRes: InventoryItem

func Collect(inventory: Inventory):
	inventory.insert(itemRes)
	queue_free()

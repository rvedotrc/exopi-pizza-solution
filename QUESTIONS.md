# Questions in response to Jonas' requirements sent via chat

## "Accepts orders from users" / "The system must allow users to place an order"

Who are the "users" in this requirement? Staff? Customers? Someone else?

What is an "order"? Does an order include any pricing information? Who needs to be able to _see_ order information?

## "The system must handle order completion in some way"

I don't know what this means. Are you saying that an order starts off as not complete, and then at some point transitions to being complete? How does the system know when that completion happens? What is the system meant to do in response to that event?

## "[The menu must] contain a collection of items"

Is than an _ordered_ collection? What is an "item" in this sense? Perhaps for example it has a name, and a price. Anything else? Perhaps it is also linked to a recipe, in which case ... what is a recipe?

## "Manages inventory"

OK, what is "inventory"? In what way does it need to be "managed"?

In the provided C# code, there were "stock items" and stock amounts. Is it therefore fair to say that the inventory tracks an amount for each stock item? Is it true that inventory amounts will always be integers? How should the system handle negative stock?

Are the stock items hard-wired in the code, or can they also be managed via the system? If the latter, what conditions need to be true before a stock item can be deleted?

## "Processes and completes orders"

What does this mean? The system doesn't _itself_ prepare and bake pizzas, so presumably you're talking about the system assisting and/or responding to that process. What does that look like?

What does it mean to "process" an order?

## "Let the users know when and our is being prepared, cooked and prepared for pickup"

Who are the "users" in this requirement? Staff? Customers? Someone else?

I assume "and our" to mean "an order".

How will the system know when an order is being prepared, cooked, and prepared for pickup?

This requirement implies some kind of state lifecycle of an order. What does that lifecycle look like? How, if at all, does the order's being prepared / cooked / prepared for pickup relate to the individual order lines (where an order contains more than one line), or indeed to the individual pizzas (where an order line is for more than one pizza)?

## "New types of items or menus"

Do you mean "items" as in "things other than pizzas"? Or do you mean "new types of pizza"? If the former, then what kind of new item type are you envisaging? In what ways will the new item types be the same as pizzas, and what ways will they be different?

Does this requirement parse as "New (types of items) or menus", or as "New types of (items or menus)"? If the latter, then what is a "menu type", and how would new menu types differ from the (implied) "menu type" that the system already would have implemented?

## "Advanced pricing logic"

What does this mean? Can you provide some examples?

## "New cooking or processing models"

What does this mean? Can you provide some examples?

# DIO - .NET learning path - Exploring the C# Language

[www.dio.me](www.dio.me)

## Project challenge

For this challenge, you'll need to use the knowledge you acquired in the "Exploring the C# Language" module from DIO's .NET learning path.

## Context

You've been hired to build a lodging system that will be used to perform reservations in a hotel. You'll need to use the `Person` class, which represents a guest, the `Suite` class, and the `Reservation` class, which will create a relationship between both.

Your program should correctly calculate the values of the `Reservation` class' methods, which will need to get the guest count and the rate price, granting a 10% discount in the case a reservation is made for a period longer than 10 days.

## Rules and validations

1. It should not be possible to create a reservation of a suite with a capacity lower than the number of guests. For example: If a suite is capable of accommodating 2 guests, then an exception should be thrown when over 3 guests try to reserve it.
2. The `GetGuestsCount` method from the `Reservation` class should return the total amount of guests, whilst the `CalculateFinalRate` method should return the final rate value (reserved days x daily rate).
3. If a reservation is made for at least 10 days, a 10% discount should be granted to the final rate value.

![The hotel's class diagram](diagrama_classe_hotel.png)

## Solution

The code is half finished, and you must continue it while following the rules described above, so that in the end we have a functional program. Look for the commented word "TODO" in the code, then implement according to the rules above.

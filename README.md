# Wide World Importers Application

## About

The ''Wide World Importers Application", from now I will use wwi-app like a shorter version of its name, was intended to put in on single project all my knownledge. I will implement best practices of coding and latest architectures and patterns like "Clean Architecture", "Command and Query Responsability Segregation (CQRS)" and "Microservices"

The requirements of this application is to allow our customers to buy our products from around the entire globe. The application will handle the shopping process from the very beggining to end. In other words,  the application will list the products to buy (a catalog), will process orders and payment methods and finally will track the shipment until the door of the buyer. Of course, security is mandatory in any e-shop application.

So far these are the microservices to implement:

- Identity: handle authentication and authorization

- Product: catalog of products

- Order: create and process an order

- Billing: process different payment methods

- Shipping: tracking of the product

# Online Bookstore - Microservices Project

Welcome to the Online Bookstore project! This is a modern, scalable, and maintainable microservices-based application built using .NET 9, Domain-Driven Design (DDD), CQRS, Clean Architecture, and various design patterns. The project is containerized using Docker, making it easy to set up and run on any platform, including macOS.

This project is designed to showcase best practices in software development, including the use of message brokers (RabbitMQ), reactive programming, and the ELK stack for centralized logging and monitoring. The application is divided into multiple microservices, each responsible for a specific domain, and communicates asynchronously using RabbitMQ.

## Table of Contents

- [Technologies Used](#technologies-used)
- [Services Overview](#services-overview)
- [Design Patterns](#design-patterns)
- [Folder Structure](#folder-structure)
- [Infrastructure](#infrastructure)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Running the Project](#running-the-project)
    - [Stopping the Project](#stopping-the-project)
- [Conclusion](#conclusion)
- [Contributing](#contributing)
- [License](#license)

## Technologies Used

- **.NET 9**: The primary framework for building the microservices.
- **PostgreSQL**: The relational database used for data storage.
- **RabbitMQ**: Message broker for asynchronous communication between services.
- **ELK Stack (Elasticsearch, Logstash, Kibana)**: Used for centralized logging and monitoring.
- **Docker**: Containerization to ensure consistency across development and production environments.
- **Ocelot**: API Gateway library for routing requests to the appropriate microservices.
- **Reactive Programming**: Used for handling asynchronous data streams and improving responsiveness.

## Services Overview

The application is divided into the following microservices:

- **Catalog Service**: Manages the inventory of books, including adding, updating, and retrieving book details.
- **Order Service**: Handles the creation and management of orders.
- **Payment Service**: Manages payment processing for orders.
- **User Service**: Handles user authentication, authorization, and profile management.
- **Notification Service**: Sends notifications to users (e.g., order confirmation, payment receipt).
- **API Gateway**: Acts as the entry point for all client requests, routing them to the appropriate microservices.

## Design Patterns

The project incorporates the following design patterns and architectural principles:

- **Domain-Driven Design (DDD)**: Structuring the application around the business domain.
- **Command Query Responsibility Segregation (CQRS)**: Separating read and write operations for better scalability and maintainability.
- **Clean Architecture**: Ensuring separation of concerns and independence of frameworks.
- **Repository Pattern**: Abstracting data access logic.
- **Mediator Pattern**: Reducing dependencies between components.
- **Saga Pattern**: Managing distributed transactions across microservices.
- **Observer Pattern**: Handling notifications and reactive programming.
- **Gateway Pattern**: Routing requests through the API Gateway.

## Folder Structure

The project follows a consistent folder structure across all services:
```
OnlineBookstore/
│
├── src/
│ ├── CatalogService/
│ │ ├── Application/
│ │ ├── Domain/
│ │ ├── Infrastructure/
│ │ ├── Presentation/
│ │ └── Dockerfile
│ ├── OrderService/
│ │ ├── Application/
│ │ ├── Domain/
│ │ ├── Infrastructure/
│ │ ├── Presentation/
│ │ └── Dockerfile
│ ├── PaymentService/
│ │ ├── Application/
│ │ ├── Domain/
│ │ ├── Infrastructure/
│ │ ├── Presentation/
│ │ └── Dockerfile
│ ├── UserService/
│ │ ├── Application/
│ │ ├── Domain/
│ │ ├── Infrastructure/
│ │ ├── Presentation/
│ │ └── Dockerfile
│ ├── NotificationService/
│ │ ├── Application/
│ │ ├── Domain/
│ │ ├── Infrastructure/
│ │ ├── Presentation/
│ │ └── Dockerfile
│ └── ApiGateway/
│ ├── OcelotConfig/
│ └── Dockerfile
│
├── docker-compose.yml
├── README.md
└── .gitignore
```

### Explanation of Folder Structure

- **Application**: Contains the application logic, including commands, queries, and handlers.
- **Domain**: Contains the core business logic and domain models.
- **Infrastructure**: Contains the implementation details, such as database contexts, repositories, and message brokers.
- **Presentation**: Contains the API controllers and other presentation logic.
- **Dockerfile**: Used to build the Docker image for each service.
- **docker-compose.yml**: Defines the multi-container Docker application, including services, networks, and volumes.

## Infrastructure

The infrastructure is managed using Docker and Docker Compose. The `docker-compose.yml` file defines the following services:

- **PostgreSQL**: The relational database used by Catalog, Order, Payment, and User services.
- **RabbitMQ**: The message broker used for inter-service communication.
- **Elasticsearch**: Used for storing and searching logs.
- **Logstash**: Used for processing logs before they are stored in Elasticsearch.
- **Kibana**: Used for visualizing logs and monitoring the system.
- **API Gateway**: The entry point for all client requests.
- **Catalog Service**: Manages the book inventory.
- **Order Service**: Handles order creation and management.
- **Payment Service**: Manages payment processing.
- **User Service**: Handles user authentication and profile management.
- **Notification Service**: Sends notifications to users.

## Getting Started

### Prerequisites

- Docker and Docker Compose installed on your machine.
- .NET 9 SDK installed (if you want to run services outside of Docker).

### Running the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/OnlineBookstore.git
   cd OnlineBookstore
   ```
2. Build and run the Docker containers:
    ```bash
    docker compose up --build
   ```
---

## Conclusion

This project demonstrates a modern approach to building scalable, maintainable, and resilient microservices using **.NET 9**, **Docker**, and various design patterns. It incorporates best practices such as **DDD**, **CQRS**, **Clean Architecture**, and **reactive programming**, making it a robust example for a portfolio project.

By leveraging **RabbitMQ** for asynchronous communication and the **ELK stack** for centralized logging and monitoring, this project provides a comprehensive example of how to build and manage a distributed system. The use of Docker ensures consistency across development and production environments, making it easy to deploy and scale.

Feel free to explore the code, modify it, and use it as a foundation for your own projects! If you have any questions or feedback, please open an issue or reach out to me directly. **Happy coding!** 🚀

---

## Contributing

Contributions are welcome! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes.
4. Submit a pull request.

---

## License

This project is licensed under the **MIT License**. See the `LICENSE` file for details.

---

Thank you for checking out the Online Bookstore project! 🎉



---
## Conclusion

This project demonstrates a modern approach to building scalable, maintainable, and resilient microservices using **.NET 9**, **Docker**, and various design patterns. It incorporates best practices such as **DDD**, **CQRS**, **Clean Architecture**, and **reactive programming**, making it a robust example for a portfolio project.

By leveraging **RabbitMQ** for asynchronous communication and the **ELK stack** for centralized logging and monitoring, this project provides a comprehensive example of how to build and manage a distributed system. The use of Docker ensures consistency across development and production environments, making it easy to deploy and scale.

Feel free to explore the code, modify it, and use it as a foundation for your own projects! If you have any questions or feedback, please open an issue or reach out to me directly. **Happy coding!** 🚀

---

## Contributing

Contributions are welcome! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes.
4. Submit a pull request.

---

## License

This project is licensed under the **MIT License**. See the `LICENSE` file for details.

---

Thank you for checking out the Online Bookstore project! 🎉

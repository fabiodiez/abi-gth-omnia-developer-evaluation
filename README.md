# Ambev Developer Evaluation - Web API

This README provides a step-by-step guide to build, run, and test the Ambev Developer Evaluation Web API using Docker.

## Prerequisites

- Docker Desktop (or Docker Engine) installed and running.
- Git installed.

## Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/fabiodiez/abi-gth-omnia-developer-evaluation.git
   cd abi-gth-omnia-developer-evaluation\template\backend
   ```

2. **Build and Run the Docker image:**

   Run the following command to build the Docker image for the Web API:

   ```bash
   docker compose up --build
   ```

3. **Verify the containers are running:**

   Check the status of the containers with the following command:

   ```bash
   docker-compose ps
   ```

4. **Access the API:**

   Once the containers are running, you can access the API documentation (Swagger) at:
   [http://localhost:8080/swagger/index.html](http://localhost:8080/swagger/index.html).

---

## Testing the API

### 1. Create a Customer User

First, create a customer user using the following payload. Save the `id` of the user as it will be used to create a sale.

**Endpoint:** `POST /api/Users`

**Payload Example:**

```json
{
  "username": "teste@teste.com",
  "password": "Teste@10203040",
  "phone": "62992616401",
  "email": "teste@teste.com",
  "status": 1,
  "role": 1
}
```

### 2. Create a Branch

Next, create a branch. Save the `id` of the branch as it will be used to create a sale.

**Endpoint:** `POST /api/Branches`

**Payload Example:**

```json
{
  "name": "São Paulo - SP"
}
```

### 3. Create Products

Create some products. Save the `id` of the products as they will be used to create a sale.

**Endpoint:** `POST /api/Products`

**Payload Example:**

```json
{
  "name": "Stella Artois",
  "description": "Stella Artois",
  "price": 7.90
}
```

You can use the `GET /api/Branches` and `GET /api/Products` endpoints to retrieve the `id`s if you didn't save them.

### 4. Create a Sale

Now you can create a sale. Below are some example payloads:

#### Sale without Discount

**Endpoint:** `POST /api/Sales`

**Payload Example:**

```json
{
  "saleDate": "2025-02-13T05:17:19.173Z",
  "customerId": "CUSTOMER_ID_HERE",
  "branchId": "BRANCH_ID_HERE",
  "isCancelled": true,
  "items": [
    {
      "productId": "PRODUCT_ID_HERE",
      "quantity": 1
    }
  ]
}
```

#### Sale with 10% Discount

**Payload Example:**

```json
{
  "saleDate": "2025-02-13T05:17:19.173Z",
  "customerId": "CUSTOMER_ID_HERE",
  "branchId": "BRANCH_ID_HERE",
  "isCancelled": true,
  "items": [
    {
      "productId": "PRODUCT_ID_HERE",
      "quantity": 4
    }
  ]
}
```

#### Sale with 20% Discount

**Payload Example:**

```json
{
  "saleDate": "2025-02-13T05:17:19.173Z",
  "customerId": "CUSTOMER_ID_HERE",
  "branchId": "BRANCH_ID_HERE",
  "isCancelled": true,
  "items": [
    {
      "productId": "PRODUCT_ID_HERE",
      "quantity": 18
    }
  ]
}
```

#### Sale Not Allowed (Quantity Exceeds Limit)

**Payload Example:**

```json
{
  "saleDate": "2025-02-13T05:17:19.173Z",
  "customerId": "CUSTOMER_ID_HERE",
  "branchId": "BRANCH_ID_HERE",
  "isCancelled": true,
  "items": [
    {
      "productId": "PRODUCT_ID_HERE",
      "quantity": 22
    }
  ]
}
```

### 5. List Sales

You can list all sales using the following endpoint:

**Endpoint:** `GET /api/Sales`

---

## Additional CRUD Operations

All other CRUD operations are available for testing. You can explore them using the Swagger documentation at  [http://localhost:8080/swagger/index.html](http://localhost:8080/swagger/index.html).

---

## Stopping the Containers

To stop the containers, run the following command in the project's root directory:

```bash
docker-compose down
```

---

## Troubleshooting

- **Container logs:** To view the logs for a specific container (e.g., the Web API), run:

  ```bash
  docker-compose logs ambev_developer_evaluation_webapi -f
  ```

- **Database connection errors:** Ensure that the PostgreSQL container is running and accessible. You can check the logs for the database container with:

  ```bash
  docker-compose logs ambev_developer_evaluation_database
  ```

- **Port conflicts:** If you have other applications running on ports 8080 or 8081, you can change the port mappings in the `docker-compose.yml` file.

---

## Project Structure

- `docker-compose.yml`: Defines the services (containers) and their configuration.
- `Dockerfile`: Contains the instructions for building the Web API Docker image.
- `src/`: Contains the source code for the Web API.

---


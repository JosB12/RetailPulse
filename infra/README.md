# Infrastructure

Infrastructure as Code (IaC) using Bicep for Azure deployments.

## Phase 1 — Local Development

All services run locally using Docker Compose from the project root.

## Phase 2 — Azure

The Bicep templates located in `/bicep` provision the Azure equivalents of the local infrastructure:

| Local | Azure |
|---------|---------|
| SQL Server Docker | Azure SQL Database |
| Kafka Docker | Azure Event Hubs |
| MinIO Docker | Azure Data Lake Storage Gen2 |
| Keycloak Docker | Azure AD B2C |
| Redis Docker | Azure Cache for Redis |
| Jupyter Docker | Azure Databricks |   
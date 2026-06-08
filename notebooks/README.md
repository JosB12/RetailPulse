# Notebooks

Data engineering pipelines built with PySpark following the Medallion Architecture pattern.

## Layers

- `bronze_ingestion.ipynb` — raw data ingestion from Kafka into MinIO Bronze
- `silver_transform.ipynb` — data cleansing and transformation into Silver
- `gold_aggregations.ipynb` — KPIs and analytical datasets into Gold

## Run Locally

Jupyter Lab is available at:

```text
http://localhost:8888
```
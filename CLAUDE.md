# CLAUDE.md -- GroundX SDK

## Overview

Auto-generated C# SDK for [GroundX](https://www.groundx.ai/) (by EyeLevel) -- RAG infrastructure platform with document ingestion, search, and content completion.
OpenAPI spec from the official [groundxai/groundx-sdks](https://github.com/groundxai/groundx-sdks) repo.

## Build & Test

```bash
dotnet build GroundX.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (sent as `X-API-Key` header via `--security-scheme`):

```csharp
var client = new GroundXClient(apiKey); // GROUNDX_API_KEY env var
```

## Key Files

- `src/libs/GroundX/openapi.yaml` -- OpenAPI spec (downloaded from groundxai/groundx-sdks)
- `src/libs/GroundX/generate.sh` -- Downloads spec, runs autosdk with `--security-scheme ApiKey:Header:X-API-Key`
- `src/libs/GroundX/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/GroundX/Extensions/GroundXClient.Tools.cs` -- MEAI AIFunction tools (AsSearchTool, AsIngestUrlTool, AsGetIngestStatusTool, AsListBucketsTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/groundxai/groundx-sdks/main/api.yaml` (3.0.0)
- Base URL: `https://api.groundx.ai/api`
- Auth: `--security-scheme ApiKey:Header:X-API-Key` sends the key directly as the native header (no spec conversion or PrepareRequest hook needed)

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/v1/ingest/documents/remote` | POST | Ingest documents from URLs |
| `/v1/ingest/documents/local` | POST | Upload local documents |
| `/v1/ingest/documents/website` | POST | Crawl and ingest a website |
| `/v1/ingest/{processId}` | GET | Get ingestion processing status |
| `/v1/ingest/documents/{id}` | GET | Lookup document by ID |
| `/v1/ingest/documents` | GET | List ingested documents |
| `/v1/ingest/documents` | DELETE | Delete documents |
| `/v1/ingest/document/{documentId}` | GET | Get single document |
| `/v1/ingest/document/{documentId}` | DELETE | Delete single document |
| `/v1/search/{id}` | POST | Search content in a bucket |
| `/v1/search/documents` | POST | Search specific documents |
| `/v1/bucket` | GET/POST | List/create buckets |
| `/v1/bucket/{bucketId}` | GET/PUT/DELETE | Get/update/delete bucket |
| `/v1/group` | GET/POST | List/create groups |
| `/v1/group/{groupId}` | GET/PUT/DELETE | Get/update/delete group |
| `/v1/group/{groupId}/bucket/{bucketId}` | POST/DELETE | Add/remove bucket from group |
| `/v1/customer` | GET | Get customer info |
| `/v1/health` | GET | Health check |
| `/v1/health/{service}` | GET | Service-specific health check |

## MEAI Tools

| Tool | Method | Description |
|------|--------|-------------|
| `AsSearchTool()` | Search | Searches ingested documents for relevant content |
| `AsIngestUrlTool()` | Ingest | Ingests a document from a public URL |
| `AsGetIngestStatusTool()` | Status | Checks ingestion processing status |
| `AsListBucketsTool()` | Buckets | Lists available content buckets |

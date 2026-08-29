CREATE EXTENSION IF NOT EXISTS postgis;
CREATE TABLE organizations(id uuid PRIMARY KEY,name text NOT NULL,slug text NOT NULL UNIQUE);
CREATE TABLE riders(id uuid PRIMARY KEY,organization_id uuid NOT NULL REFERENCES organizations(id),reference text NOT NULL,payload jsonb NOT NULL,UNIQUE(organization_id,reference));
CREATE TABLE trip_requests(id uuid PRIMARY KEY,organization_id uuid NOT NULL REFERENCES organizations(id),rider_id uuid NOT NULL,status text NOT NULL,pickup geography(Point,4326) NOT NULL,dropoff geography(Point,4326) NOT NULL,payload jsonb NOT NULL,requested_at timestamptz NOT NULL);
CREATE INDEX trip_pickup_gix ON trip_requests USING gist(pickup);
CREATE TABLE vehicles(id uuid PRIMARY KEY,organization_id uuid NOT NULL REFERENCES organizations(id),registration text NOT NULL,status text NOT NULL,payload jsonb NOT NULL,UNIQUE(organization_id,registration));
CREATE TABLE dispatch_assignments(id uuid PRIMARY KEY,organization_id uuid NOT NULL REFERENCES organizations(id),vehicle_id uuid NOT NULL,driver_id uuid NOT NULL,status text NOT NULL,payload jsonb NOT NULL);
CREATE TABLE outbox_events(id uuid PRIMARY KEY,organization_id uuid NOT NULL REFERENCES organizations(id),subject text NOT NULL,aggregate_id text NOT NULL,payload jsonb NOT NULL,occurred_at timestamptz NOT NULL,published_at timestamptz,attempts int NOT NULL DEFAULT 0);

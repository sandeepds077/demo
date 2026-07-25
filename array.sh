#!/usr/bin/env bash

args=("$@")

echo "arguments using \$@:"
for arg in "${args[@]}"; do
  echo "$arg"
done

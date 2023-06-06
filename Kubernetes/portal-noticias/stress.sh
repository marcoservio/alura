#!/bin/bash
for i in {1..10000}; do
  curl global-old.com/index.php
  sleep $1
done

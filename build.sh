#!/bin/bash
proj_name="CLO"
proj_tests="${proj_name}.Tests"
cd "$proj_name"
dotnet build
cd ..
﻿namespace TMModels;

public record Season(
    string Name,
    DateTimeOffset? StartDate,
    DateTimeOffset? EndDate,
    string[] Divisions
    );
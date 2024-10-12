# coding: utf-8

"""
    Connection Rest API 1.0

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

    The version of the OpenAPI document: 1.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import json
from enum import Enum
from typing_extensions import Self


class AnchorType(str, Enum):
    """
    Defines a type of anchor end.
    """

    """
    allowed enum values
    """
    STRAIGHT = 'straight'
    WASHERPLATECIRCULAR = 'washerPlateCircular'
    WASHERPLATERECTANGULAR = 'washerPlateRectangular'

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of AnchorType from a JSON string"""
        return cls(json.loads(json_str))



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


class CrtCompCheckIS(str, Enum):
    """
    CRT IS check
    """

    """
    allowed enum values
    """
    I_S800_CL_7_4 = 'iS800_Cl_7_4'
    I_S456_CL_34_4 = 'iS456_Cl_34_4'

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of CrtCompCheckIS from a JSON string"""
        return cls(json.loads(json_str))



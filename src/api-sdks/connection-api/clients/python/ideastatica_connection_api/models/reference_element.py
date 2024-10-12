# coding: utf-8

"""
    Connection Rest API 1.0

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

    The version of the OpenAPI document: 1.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from pydantic import BaseModel, ConfigDict, Field, StrictInt, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from ideastatica_connection_api.models.open_element_id import OpenElementId
from typing import Optional, Set
from typing_extensions import Self

class ReferenceElement(BaseModel):
    """
    Reference element class
    """ # noqa: E501
    type_name: Optional[StrictStr] = Field(default=None, description="Element type name", alias="typeName")
    id: Optional[StrictInt] = Field(default=None, description="Element Id")
    element: Optional[OpenElementId] = None
    __properties: ClassVar[List[str]] = ["typeName", "id", "element"]

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of ReferenceElement from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        """
        excluded_fields: Set[str] = set([
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of element
        if self.element:
            _dict['element'] = self.element.to_dict()
        # set to None if type_name (nullable) is None
        # and model_fields_set contains the field
        if self.type_name is None and "type_name" in self.model_fields_set:
            _dict['typeName'] = None

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of ReferenceElement from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "typeName": obj.get("typeName"),
            "id": obj.get("id"),
            "element": OpenElementId.from_dict(obj["element"]) if obj.get("element") is not None else None
        })
        return _obj



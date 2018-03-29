-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
module('logintest_pb')


local TYPE = protobuf.EnumDescriptor();
local TYPE_NONE_ENUM = protobuf.EnumValueDescriptor();
local TYPE_ONE_ENUM = protobuf.EnumValueDescriptor();
local TYPE_TWO_ENUM = protobuf.EnumValueDescriptor();
local LOGINTESTREQUEST = protobuf.Descriptor();
local LOGINTESTREQUEST_INFOS = protobuf.Descriptor();
local LOGINTESTREQUEST_INFOS_INTDEX_FIELD = protobuf.FieldDescriptor();
local LOGINTESTREQUEST_INFOS_NAME_FIELD = protobuf.FieldDescriptor();
local LOGINTESTREQUEST_ID_FIELD = protobuf.FieldDescriptor();
local LOGINTESTREQUEST_NAME_FIELD = protobuf.FieldDescriptor();
local LOGINTESTREQUEST_EMAIL_FIELD = protobuf.FieldDescriptor();
local LOGINTESTREQUEST_INFODIC_FIELD = protobuf.FieldDescriptor();
local LOGINTESTRESPONSE = protobuf.Descriptor();
local LOGINTESTRESPONSE_ID_FIELD = protobuf.FieldDescriptor();
local LOGINTESTRESPONSE_NAME_FIELD = protobuf.FieldDescriptor();
local LOGINTESTRESPONSE_INFOS_FIELD = protobuf.FieldDescriptor();
local INFO = protobuf.Descriptor();
local INFO_ID_FIELD = protobuf.FieldDescriptor();
local INFO_NAME_FIELD = protobuf.FieldDescriptor();
local INFO_TYPE_FIELD = protobuf.FieldDescriptor();

TYPE_NONE_ENUM.name = "None"
TYPE_NONE_ENUM.index = 0
TYPE_NONE_ENUM.number = 0
TYPE_ONE_ENUM.name = "One"
TYPE_ONE_ENUM.index = 1
TYPE_ONE_ENUM.number = 1
TYPE_TWO_ENUM.name = "Two"
TYPE_TWO_ENUM.index = 2
TYPE_TWO_ENUM.number = 2
TYPE.name = "Type"
TYPE.full_name = ".Type"
TYPE.values = {TYPE_NONE_ENUM,TYPE_ONE_ENUM,TYPE_TWO_ENUM}
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.name = "intdex"
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.full_name = ".LoginTestRequest.infos.intdex"
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.number = 1
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.index = 0
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.label = 1
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.has_default_value = false
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.default_value = 0
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.type = 5
LOGINTESTREQUEST_INFOS_INTDEX_FIELD.cpp_type = 1

LOGINTESTREQUEST_INFOS_NAME_FIELD.name = "name"
LOGINTESTREQUEST_INFOS_NAME_FIELD.full_name = ".LoginTestRequest.infos.name"
LOGINTESTREQUEST_INFOS_NAME_FIELD.number = 2
LOGINTESTREQUEST_INFOS_NAME_FIELD.index = 1
LOGINTESTREQUEST_INFOS_NAME_FIELD.label = 1
LOGINTESTREQUEST_INFOS_NAME_FIELD.has_default_value = false
LOGINTESTREQUEST_INFOS_NAME_FIELD.default_value = ""
LOGINTESTREQUEST_INFOS_NAME_FIELD.type = 9
LOGINTESTREQUEST_INFOS_NAME_FIELD.cpp_type = 9

LOGINTESTREQUEST_INFOS.name = "infos"
LOGINTESTREQUEST_INFOS.full_name = ".LoginTestRequest.infos"
LOGINTESTREQUEST_INFOS.nested_types = {}
LOGINTESTREQUEST_INFOS.enum_types = {}
LOGINTESTREQUEST_INFOS.fields = {LOGINTESTREQUEST_INFOS_INTDEX_FIELD, LOGINTESTREQUEST_INFOS_NAME_FIELD}
LOGINTESTREQUEST_INFOS.is_extendable = false
LOGINTESTREQUEST_INFOS.extensions = {}
LOGINTESTREQUEST_INFOS.containing_type = LOGINTESTREQUEST
LOGINTESTREQUEST_ID_FIELD.name = "id"
LOGINTESTREQUEST_ID_FIELD.full_name = ".LoginTestRequest.id"
LOGINTESTREQUEST_ID_FIELD.number = 1
LOGINTESTREQUEST_ID_FIELD.index = 0
LOGINTESTREQUEST_ID_FIELD.label = 2
LOGINTESTREQUEST_ID_FIELD.has_default_value = false
LOGINTESTREQUEST_ID_FIELD.default_value = 0
LOGINTESTREQUEST_ID_FIELD.type = 5
LOGINTESTREQUEST_ID_FIELD.cpp_type = 1

LOGINTESTREQUEST_NAME_FIELD.name = "name"
LOGINTESTREQUEST_NAME_FIELD.full_name = ".LoginTestRequest.name"
LOGINTESTREQUEST_NAME_FIELD.number = 2
LOGINTESTREQUEST_NAME_FIELD.index = 1
LOGINTESTREQUEST_NAME_FIELD.label = 2
LOGINTESTREQUEST_NAME_FIELD.has_default_value = false
LOGINTESTREQUEST_NAME_FIELD.default_value = ""
LOGINTESTREQUEST_NAME_FIELD.type = 9
LOGINTESTREQUEST_NAME_FIELD.cpp_type = 9

LOGINTESTREQUEST_EMAIL_FIELD.name = "email"
LOGINTESTREQUEST_EMAIL_FIELD.full_name = ".LoginTestRequest.email"
LOGINTESTREQUEST_EMAIL_FIELD.number = 3
LOGINTESTREQUEST_EMAIL_FIELD.index = 2
LOGINTESTREQUEST_EMAIL_FIELD.label = 1
LOGINTESTREQUEST_EMAIL_FIELD.has_default_value = false
LOGINTESTREQUEST_EMAIL_FIELD.default_value = ""
LOGINTESTREQUEST_EMAIL_FIELD.type = 9
LOGINTESTREQUEST_EMAIL_FIELD.cpp_type = 9

LOGINTESTREQUEST_INFODIC_FIELD.name = "infoDic"
LOGINTESTREQUEST_INFODIC_FIELD.full_name = ".LoginTestRequest.infoDic"
LOGINTESTREQUEST_INFODIC_FIELD.number = 4
LOGINTESTREQUEST_INFODIC_FIELD.index = 3
LOGINTESTREQUEST_INFODIC_FIELD.label = 3
LOGINTESTREQUEST_INFODIC_FIELD.has_default_value = false
LOGINTESTREQUEST_INFODIC_FIELD.default_value = {}
LOGINTESTREQUEST_INFODIC_FIELD.message_type = LOGINTESTREQUEST_INFOS
LOGINTESTREQUEST_INFODIC_FIELD.type = 11
LOGINTESTREQUEST_INFODIC_FIELD.cpp_type = 10

LOGINTESTREQUEST.name = "LoginTestRequest"
LOGINTESTREQUEST.full_name = ".LoginTestRequest"
LOGINTESTREQUEST.nested_types = {LOGINTESTREQUEST_INFOS}
LOGINTESTREQUEST.enum_types = {}
LOGINTESTREQUEST.fields = {LOGINTESTREQUEST_ID_FIELD, LOGINTESTREQUEST_NAME_FIELD, LOGINTESTREQUEST_EMAIL_FIELD, LOGINTESTREQUEST_INFODIC_FIELD}
LOGINTESTREQUEST.is_extendable = false
LOGINTESTREQUEST.extensions = {}
LOGINTESTRESPONSE_ID_FIELD.name = "id"
LOGINTESTRESPONSE_ID_FIELD.full_name = ".LoginTestResponse.id"
LOGINTESTRESPONSE_ID_FIELD.number = 1
LOGINTESTRESPONSE_ID_FIELD.index = 0
LOGINTESTRESPONSE_ID_FIELD.label = 1
LOGINTESTRESPONSE_ID_FIELD.has_default_value = true
LOGINTESTRESPONSE_ID_FIELD.default_value = 0
LOGINTESTRESPONSE_ID_FIELD.type = 5
LOGINTESTRESPONSE_ID_FIELD.cpp_type = 1

LOGINTESTRESPONSE_NAME_FIELD.name = "name"
LOGINTESTRESPONSE_NAME_FIELD.full_name = ".LoginTestResponse.name"
LOGINTESTRESPONSE_NAME_FIELD.number = 2
LOGINTESTRESPONSE_NAME_FIELD.index = 1
LOGINTESTRESPONSE_NAME_FIELD.label = 1
LOGINTESTRESPONSE_NAME_FIELD.has_default_value = false
LOGINTESTRESPONSE_NAME_FIELD.default_value = ""
LOGINTESTRESPONSE_NAME_FIELD.type = 9
LOGINTESTRESPONSE_NAME_FIELD.cpp_type = 9

LOGINTESTRESPONSE_INFOS_FIELD.name = "infos"
LOGINTESTRESPONSE_INFOS_FIELD.full_name = ".LoginTestResponse.infos"
LOGINTESTRESPONSE_INFOS_FIELD.number = 3
LOGINTESTRESPONSE_INFOS_FIELD.index = 2
LOGINTESTRESPONSE_INFOS_FIELD.label = 3
LOGINTESTRESPONSE_INFOS_FIELD.has_default_value = false
LOGINTESTRESPONSE_INFOS_FIELD.default_value = {}
LOGINTESTRESPONSE_INFOS_FIELD.message_type = INFO
LOGINTESTRESPONSE_INFOS_FIELD.type = 11
LOGINTESTRESPONSE_INFOS_FIELD.cpp_type = 10

LOGINTESTRESPONSE.name = "LoginTestResponse"
LOGINTESTRESPONSE.full_name = ".LoginTestResponse"
LOGINTESTRESPONSE.nested_types = {}
LOGINTESTRESPONSE.enum_types = {}
LOGINTESTRESPONSE.fields = {LOGINTESTRESPONSE_ID_FIELD, LOGINTESTRESPONSE_NAME_FIELD, LOGINTESTRESPONSE_INFOS_FIELD}
LOGINTESTRESPONSE.is_extendable = false
LOGINTESTRESPONSE.extensions = {}
INFO_ID_FIELD.name = "id"
INFO_ID_FIELD.full_name = ".info.id"
INFO_ID_FIELD.number = 1
INFO_ID_FIELD.index = 0
INFO_ID_FIELD.label = 1
INFO_ID_FIELD.has_default_value = true
INFO_ID_FIELD.default_value = 0
INFO_ID_FIELD.type = 5
INFO_ID_FIELD.cpp_type = 1

INFO_NAME_FIELD.name = "name"
INFO_NAME_FIELD.full_name = ".info.name"
INFO_NAME_FIELD.number = 2
INFO_NAME_FIELD.index = 1
INFO_NAME_FIELD.label = 1
INFO_NAME_FIELD.has_default_value = false
INFO_NAME_FIELD.default_value = ""
INFO_NAME_FIELD.type = 9
INFO_NAME_FIELD.cpp_type = 9

INFO_TYPE_FIELD.name = "type"
INFO_TYPE_FIELD.full_name = ".info.type"
INFO_TYPE_FIELD.number = 3
INFO_TYPE_FIELD.index = 2
INFO_TYPE_FIELD.label = 1
INFO_TYPE_FIELD.has_default_value = true
INFO_TYPE_FIELD.default_value = None
INFO_TYPE_FIELD.enum_type = TYPE
INFO_TYPE_FIELD.type = 14
INFO_TYPE_FIELD.cpp_type = 8

INFO.name = "info"
INFO.full_name = ".info"
INFO.nested_types = {}
INFO.enum_types = {}
INFO.fields = {INFO_ID_FIELD, INFO_NAME_FIELD, INFO_TYPE_FIELD}
INFO.is_extendable = false
INFO.extensions = {}

LoginTestRequest = protobuf.Message(LOGINTESTREQUEST)
LoginTestRequest.infos = protobuf.Message(LOGINTESTREQUEST_INFOS)
LoginTestResponse = protobuf.Message(LOGINTESTRESPONSE)
None = 0
One = 1
Two = 2
info = protobuf.Message(INFO)

﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Protocols_ProtocolWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Protocols.Protocol), typeof(System.Object));
		L.RegFunction("GetID", GetID);
		L.RegFunction("GetSource", GetSource);
		L.RegFunction("SetSource", SetSource);
		L.RegFunction("GetDest", GetDest);
		L.RegFunction("SetDest", SetDest);
		L.RegFunction("GetRoleID", GetRoleID);
		L.RegFunction("SetRoleID", SetRoleID);
		L.RegFunction("GetSessionID", GetSessionID);
		L.RegFunction("SetSessionID", SetSessionID);
		L.RegFunction("GetBody", GetBody);
		L.RegFunction("SetBody", SetBody);
		L.RegFunction("GetBodySize", GetBodySize);
		L.RegFunction("Serialize", Serialize);
		L.RegFunction("Deserialize", Deserialize);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateProtocols_Protocol);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateProtocols_Protocol(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Protocols.Protocol obj = new Protocols.Protocol();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				Protocols.ProtoBody arg0 = (Protocols.ProtoBody)ToLua.CheckObject<Protocols.ProtoBody>(L, 1);
				Protocols.Protocol obj = new Protocols.Protocol(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				Protocols.ProtoID arg0 = (Protocols.ProtoID)ToLua.CheckObject<Protocols.ProtoID>(L, 1);
				Protocols.ProtoBody arg1 = (Protocols.ProtoBody)ToLua.CheckObject<Protocols.ProtoBody>(L, 2);
				Protocols.Protocol obj = new Protocols.Protocol(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Protocols.Protocol.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			Protocols.ProtoID o = obj.GetID();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint o = obj.GetSource();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.SetSource(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDest(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint o = obj.GetDest();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDest(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.SetDest(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRoleID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			ulong o = obj.GetRoleID();
			LuaDLL.tolua_pushuint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRoleID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			ulong arg0 = LuaDLL.tolua_checkuint64(L, 2);
			obj.SetRoleID(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSessionID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint o = obj.GetSessionID();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSessionID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.SetSessionID(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBody(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			Protocols.ProtoBody o = obj.GetBody();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBody(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			Protocols.ProtoBody arg0 = (Protocols.ProtoBody)ToLua.CheckObject<Protocols.ProtoBody>(L, 2);
			obj.SetBody(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBodySize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			uint o = obj.GetBodySize();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Serialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
			int o = obj.Serialize(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Deserialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
			int o = obj.Deserialize(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Protocols.Protocol obj = (Protocols.Protocol)ToLua.CheckObject<Protocols.Protocol>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

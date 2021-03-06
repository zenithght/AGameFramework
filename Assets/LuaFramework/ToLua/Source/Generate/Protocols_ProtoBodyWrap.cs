﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Protocols_ProtoBodyWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Protocols.ProtoBody), typeof(System.Object));
		L.RegFunction("RegisterSerializeFunc", RegisterSerializeFunc);
		L.RegFunction("New", _CreateProtocols_ProtoBody);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegFunction("DeserializeFunc", Protocols_ProtoBody_DeserializeFunc);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateProtocols_ProtoBody(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Protocols.ProtoBody obj = new Protocols.ProtoBody();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Protocols.ProtoBody.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterSerializeFunc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Action<System.IO.Stream,Protocols.ProtoBody> arg0 = (System.Action<System.IO.Stream,Protocols.ProtoBody>)ToLua.CheckDelegate<System.Action<System.IO.Stream,Protocols.ProtoBody>>(L, 1);
			Protocols.ProtoBody.DeserializeFunc arg1 = (Protocols.ProtoBody.DeserializeFunc)ToLua.CheckDelegate<Protocols.ProtoBody.DeserializeFunc>(L, 2);
			Protocols.ProtoBody.RegisterSerializeFunc(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Protocols_ProtoBody_DeserializeFunc(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<Protocols.ProtoBody.DeserializeFunc>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<Protocols.ProtoBody.DeserializeFunc>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


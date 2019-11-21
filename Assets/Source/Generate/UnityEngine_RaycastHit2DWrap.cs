﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_RaycastHit2DWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.RaycastHit2D), null);
		L.RegFunction("CompareTo", CompareTo);
		L.RegFunction("New", _CreateUnityEngine_RaycastHit2D);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("centroid", get_centroid, set_centroid);
		L.RegVar("point", get_point, set_point);
		L.RegVar("normal", get_normal, set_normal);
		L.RegVar("distance", get_distance, set_distance);
		L.RegVar("fraction", get_fraction, set_fraction);
		L.RegVar("collider", get_collider, null);
		L.RegVar("rigidbody", get_rigidbody, null);
		L.RegVar("transform", get_transform, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_RaycastHit2D(IntPtr L)
	{
		UnityEngine.RaycastHit2D obj = new UnityEngine.RaycastHit2D();
		ToLua.PushValue(L, obj);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.RaycastHit2D));
			UnityEngine.RaycastHit2D arg0 = StackTraits<UnityEngine.RaycastHit2D>.Check(L, 2);
			int o = obj.CompareTo(arg0);
			LuaDLL.lua_pushinteger(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_centroid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Vector2 ret = obj.centroid;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index centroid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_point(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Vector2 ret = obj.point;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index point on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Vector2 ret = obj.normal;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index normal on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_distance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			float ret = obj.distance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index distance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fraction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			float ret = obj.fraction;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fraction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collider(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Collider2D ret = obj.collider;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index collider on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rigidbody(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Rigidbody2D ret = obj.rigidbody;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rigidbody on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Transform ret = obj.transform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_centroid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.centroid = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index centroid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_point(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.point = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index point on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_normal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.normal = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index normal on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_distance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.distance = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index distance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fraction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RaycastHit2D obj = (UnityEngine.RaycastHit2D)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.fraction = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fraction on a nil value");
		}
	}
}

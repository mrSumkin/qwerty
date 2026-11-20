using System;
using System.Reflection;

// Token: 0x020000A0 RID: 160
public class boo
{
	// Token: 0x060003AB RID: 939 RVA: 0x00011A88 File Offset: 0x0000FC88
	public static object a(object A_0, string A_1)
	{
		czh.a(A_0, "context");
		if (string.IsNullOrEmpty(A_1))
		{
			return A_0;
		}
		string[] array = A_1.Split(new char[]
		{
			'.'
		});
		object obj = A_0;
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				PropertyInfo property = obj.GetType().GetProperty(array[i]);
				if (!(property != null))
				{
					throw new Exception("Could not find property named " + array[i]);
				}
				obj = property.GetValue(obj, null);
			}
		}
		return obj;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00011B20 File Offset: 0x0000FD20
	public static void a(object A_0, string A_1, object A_2)
	{
		czh.a(A_0, "target");
		czh.a(A_1, "path");
		string[] array = A_1.Split(new char[]
		{
			'.'
		});
		object obj = A_0;
		for (int i = 0; i < array.Length; i++)
		{
			PropertyInfo property = obj.GetType().GetProperty(array[i]);
			if (property != null)
			{
				if (i != array.Length - 1)
				{
					obj = property.GetValue(obj, null);
				}
				else
				{
					property.SetValue(obj, A_2, null);
				}
			}
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00011BAC File Offset: 0x0000FDAC
	public static T GetSingletonCustomAttribute<T>(Type type) where T : Attribute
	{
		if (type != null)
		{
			object[] customAttributes = type.GetCustomAttributes(typeof(T), false);
			if (customAttributes != null && customAttributes.Length != 0)
			{
				return customAttributes[0] as T;
			}
		}
		return default(T);
	}
}

using System;
using Ouroboros.Core.Logging;

// Token: 0x0200013F RID: 319
public class d8z
{
	// Token: 0x060007DC RID: 2012 RVA: 0x00021C20 File Offset: 0x0001FE20
	private static object a(bq8 A_0, bq8 A_1, ref string A_2, out bq8 A_3, out string A_4)
	{
		czh.a(A_2, "path");
		A_3 = null;
		A_4 = null;
		string[] array = A_2.Split(new char[]
		{
			'.'
		}, StringSplitOptions.RemoveEmptyEntries);
		if (array != null && array.Length >= 1)
		{
			string text = array[0].ToLower();
			object propertyValue;
			bool flag;
			if (!(text == "context"))
			{
				if (!(text == "tempcontext"))
				{
					propertyValue = A_0.GetPropertyValue(array[0]);
					A_3 = A_0;
					flag = false;
				}
				else
				{
					if (A_1 == null)
					{
						A_2 = null;
						return null;
					}
					propertyValue = A_1.GetPropertyValue(array[1]);
					A_3 = A_1;
					flag = true;
				}
			}
			else
			{
				propertyValue = A_0.GetPropertyValue(array[1]);
				A_3 = A_0;
				flag = true;
			}
			if (flag)
			{
				A_4 = array[1];
				if (array.Length > 2)
				{
					A_2 = A_2.Remove(0, array[0].Length + array[1].Length + 2);
				}
				else
				{
					A_2 = string.Empty;
				}
			}
			else
			{
				A_4 = array[0];
				if (array.Length > 1)
				{
					A_2 = A_2.Remove(0, array[0].Length + 1);
				}
				else
				{
					A_2 = string.Empty;
				}
			}
			return propertyValue;
		}
		return null;
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00021D74 File Offset: 0x0001FF74
	public static object a(bq8 A_0, bq8 A_1, string A_2)
	{
		bq8 bq;
		string text;
		object obj = d8z.a(A_0, A_1, ref A_2, out bq, out text);
		object result;
		try
		{
			if (string.IsNullOrEmpty(A_2))
			{
				result = obj;
			}
			else
			{
				result = boo.a(obj, A_2);
			}
		}
		catch (Exception ex)
		{
			string str = "Error trying to get property value. Exception: " + ex.ToString();
			if (d8z.a != null && d8z.a.n8() && d8z.a.n9(LogSeverity.Error, 115))
			{
				d8z.a.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00021E20 File Offset: 0x00020020
	public static void a(bq8 A_0, bq8 A_1, string A_2, object A_3)
	{
		bq8 bq;
		string text;
		object obj = d8z.a(A_0, A_1, ref A_2, out bq, out text);
		try
		{
			if (string.IsNullOrEmpty(A_2))
			{
				if (bq != null && !string.IsNullOrEmpty(text))
				{
					if (A_3 == null)
					{
						bq.RemoveProperty(text);
					}
					else
					{
						bq.SetPropertyValue(text, A_3);
					}
				}
			}
			else if (obj == null)
			{
				string str = string.Format("Property '{0}'not found in context or its value was null.", A_2);
				if (d8z.a != null && d8z.a.n8() && d8z.a.n9(LogSeverity.Error, 115))
				{
					d8z.a.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
				}
			}
			else
			{
				boo.a(obj, A_2, A_3);
			}
		}
		catch (Exception ex)
		{
			string str2 = "Error trying to set property value. Exception: " + ex.ToString();
			if (d8z.a != null && d8z.a.n8() && d8z.a.n9(LogSeverity.Error, 115))
			{
				d8z.a.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str2);
			}
			throw;
		}
	}

	// Token: 0x04000586 RID: 1414
	private static cvq a = dr3.e();
}

using System;
using System.Collections.Generic;
using System.Linq;
using Ouroboros.Core.Logging;

// Token: 0x02001346 RID: 4934
public static class e40
{
	// Token: 0x06006FBA RID: 28602 RVA: 0x002ED970 File Offset: 0x002EBB70
	static e40()
	{
		e40.a();
	}

	// Token: 0x06006FBB RID: 28603 RVA: 0x002ED97C File Offset: 0x002EBB7C
	public static bb0 a(car A_0)
	{
		bb0 result;
		e40.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06006FBC RID: 28604 RVA: 0x002ED998 File Offset: 0x002EBB98
	private static void a()
	{
		e40.a = new Dictionary<car, bb0>();
		foreach (Type type in typeof(e40).Assembly.GetTypes())
		{
			if (type.IsClass && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null && typeof(bb0).IsAssignableFrom(type))
			{
				car? car = e40.a(type);
				if (car != null)
				{
					try
					{
						bb0 value = (bb0)Activator.CreateInstance(type);
						e40.a[car.Value] = value;
					}
					catch (Exception a_)
					{
						dux.a(LogSeverity.Error, a_, "Failed to create instance of weapon usage effect actuator of type '{0}'.", new object[]
						{
							type.FullName
						});
					}
				}
			}
		}
	}

	// Token: 0x06006FBD RID: 28605 RVA: 0x002EDA8C File Offset: 0x002EBC8C
	private static car? a(Type A_0)
	{
		d50 d = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(d50), false)) as d50;
		if (d != null)
		{
			return new car?(d.a());
		}
		return null;
	}

	// Token: 0x04002D9F RID: 11679
	private static Dictionary<car, bb0> a;
}

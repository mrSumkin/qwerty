using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;

// Token: 0x0200185A RID: 6234
public sealed class b06 : bjk
{
	// Token: 0x060084EB RID: 34027 RVA: 0x00374138 File Offset: 0x00372338
	public b06()
	{
		this.a(true);
	}

	// Token: 0x060084EC RID: 34028 RVA: 0x00374154 File Offset: 0x00372354
	public ai ac5(string A_0)
	{
		ai ai = this.b(A_0);
		if (ai == null)
		{
			ai = b06.a(A_0);
			if (ai == null)
			{
				dux.b(LogSeverity.Error, "Failed to retrieve script workflow '{0}'.", new object[]
				{
					A_0
				});
			}
		}
		return ai;
	}

	// Token: 0x060084ED RID: 34029 RVA: 0x00374194 File Offset: 0x00372394
	public btm ac6(string A_0, params object[] A_1)
	{
		czh.a(A_0, "workflowName");
		try
		{
			Type type = this.c(A_0);
			if (type == null)
			{
				throw new TypeLoadException(string.Format("Failed to load implementation type for workflow '{0}'.", A_0));
			}
			btm btm = Activator.CreateInstance(type, A_1) as btm;
			if (btm == null)
			{
				throw new InvalidCastException("Instantiated workflow did not derive from type: " + typeof(btm).FullName);
			}
			dux.b(LogSeverity.Information, rz.q, new object[]
			{
				type.FullName
			});
			return btm;
		}
		catch (Exception a_)
		{
			dux.a(a_, LogSeverity.CriticalError, rz.d, new object[]
			{
				A_0
			});
		}
		return null;
	}

	// Token: 0x060084EE RID: 34030 RVA: 0x00374254 File Offset: 0x00372454
	private Type c(string A_0)
	{
		Type result;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060084EF RID: 34031 RVA: 0x00374274 File Offset: 0x00372474
	private ai b(string A_0)
	{
		try
		{
			Type type = this.c(A_0);
			if (type != null)
			{
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					return constructor.Invoke(null) as ai;
				}
			}
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while trying to retrieved precomipled script workflow '{0}'.", new object[]
			{
				A_0
			});
		}
		return null;
	}

	// Token: 0x060084F0 RID: 34032 RVA: 0x003742F4 File Offset: 0x003724F4
	private static ai a(string A_0)
	{
		try
		{
			return eoq.DeserializeFromBinaryFileCompressed<ai>(d5x.a(A_0.Replace('/', '\\')), dds.a(), true);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error occurred while trying to retrieved content script workflow '{0}'.", new object[]
			{
				A_0
			});
		}
		return null;
	}

	// Token: 0x060084F1 RID: 34033 RVA: 0x00374350 File Offset: 0x00372550
	private void a(bool A_0)
	{
		this.a.Clear();
		ei2 serviceOrThrow = bpo.GetServiceOrThrow<ei2>();
		serviceOrThrow.av2(new Func<Type, bool>(this.a));
		if (A_0)
		{
			serviceOrThrow.avy(new EventHandler<EventArgs>(this.a));
		}
	}

	// Token: 0x060084F2 RID: 34034 RVA: 0x0037439C File Offset: 0x0037259C
	private void a(object A_0, EventArgs A_1)
	{
		this.a(false);
	}

	// Token: 0x060084F3 RID: 34035 RVA: 0x003743A8 File Offset: 0x003725A8
	private bool b(Type A_0)
	{
		e79 e = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(e79), false)) as e79;
		if (e != null)
		{
			this.a[e.a()] = A_0;
			return true;
		}
		return false;
	}

	// Token: 0x060084F4 RID: 34036 RVA: 0x003743EC File Offset: 0x003725EC
	[CompilerGenerated]
	private bool a(Type A_0)
	{
		return A_0.IsClass && !A_0.IsAbstract && typeof(btm).IsAssignableFrom(A_0) && this.b(A_0);
	}

	// Token: 0x040032F7 RID: 13047
	private Dictionary<string, Type> a = new Dictionary<string, Type>();
}

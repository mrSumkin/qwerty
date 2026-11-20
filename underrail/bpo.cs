using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020000B7 RID: 183
public class bpo : IServiceProvider
{
	// Token: 0x0600041F RID: 1055 RVA: 0x000138B0 File Offset: 0x00011AB0
	public static IServiceProvider c()
	{
		return bpo.b;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x000138B8 File Offset: 0x00011AB8
	public static IServiceProvider b()
	{
		return bpo.c;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x000138C0 File Offset: 0x00011AC0
	public static void a(IServiceProvider A_0)
	{
		bpo.c = A_0;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x000138CC File Offset: 0x00011ACC
	[CompilerGenerated]
	public static void d(EventHandler<d2u> A_0)
	{
		EventHandler<d2u> eventHandler = bpo.d;
		EventHandler<d2u> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d2u> value = (EventHandler<d2u>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d2u>>(ref bpo.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00013900 File Offset: 0x00011B00
	[CompilerGenerated]
	public static void c(EventHandler<d2u> A_0)
	{
		EventHandler<d2u> eventHandler = bpo.d;
		EventHandler<d2u> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d2u> value = (EventHandler<d2u>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d2u>>(ref bpo.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00013934 File Offset: 0x00011B34
	[CompilerGenerated]
	public static void b(EventHandler<d2u> A_0)
	{
		EventHandler<d2u> eventHandler = bpo.e;
		EventHandler<d2u> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d2u> value = (EventHandler<d2u>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d2u>>(ref bpo.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00013968 File Offset: 0x00011B68
	[CompilerGenerated]
	public static void a(EventHandler<d2u> A_0)
	{
		EventHandler<d2u> eventHandler = bpo.e;
		EventHandler<d2u> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d2u> value = (EventHandler<d2u>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d2u>>(ref bpo.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x0001399C File Offset: 0x00011B9C
	public static void RegisterService<T>(T service) where T : class
	{
		czh.a(service, "service");
		if (bpo.a.ContainsKey(typeof(T)))
		{
			throw new ArgumentException("Service of that type already exists.");
		}
		bpo.a.Add(typeof(T), service);
		if (bpo.d != null)
		{
			bpo.d(bpo.c(), new d2u(service));
		}
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00013A1C File Offset: 0x00011C1C
	public static T GetService<T>() where T : class
	{
		object service;
		bpo.a.TryGetValue(typeof(T), out service);
		if (service != null)
		{
			return service as T;
		}
		if (bpo.b() != null)
		{
			service = bpo.b().GetService(typeof(T));
			return service as T;
		}
		return default(T);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00013A88 File Offset: 0x00011C88
	public static T GetServiceOrThrow<T>() where T : class
	{
		T service = bpo.GetService<T>();
		if (service == null)
		{
			throw new ehu(typeof(T));
		}
		return service;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00013AAC File Offset: 0x00011CAC
	public static void UnregisterService<T>() where T : class
	{
		if (bpo.a.ContainsKey(typeof(T)))
		{
			bpo.a(typeof(T));
		}
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00013AD8 File Offset: 0x00011CD8
	public static void a()
	{
		List<Type> list = new List<Type>(bpo.a.Keys);
		for (int i = list.Count - 1; i >= 0; i--)
		{
			bpo.a(list[i]);
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00013B18 File Offset: 0x00011D18
	private static void a(Type A_0)
	{
		object a_ = bpo.a[A_0];
		bpo.a.Remove(A_0);
		if (bpo.e != null)
		{
			bpo.e(bpo.c(), new d2u(a_));
		}
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00013B5C File Offset: 0x00011D5C
	public object GetService(Type serviceType)
	{
		object service;
		bpo.a.TryGetValue(serviceType, out service);
		if (service != null)
		{
			return service;
		}
		if (bpo.b() != null)
		{
			service = bpo.b().GetService(serviceType);
			return service;
		}
		return null;
	}

	// Token: 0x04000437 RID: 1079
	private static Dictionary<Type, object> a = new Dictionary<Type, object>();

	// Token: 0x04000438 RID: 1080
	private static IServiceProvider b = new bpo();

	// Token: 0x04000439 RID: 1081
	private static IServiceProvider c;

	// Token: 0x0400043A RID: 1082
	[CompilerGenerated]
	private static EventHandler<d2u> d;

	// Token: 0x0400043B RID: 1083
	[CompilerGenerated]
	private static EventHandler<d2u> e;
}

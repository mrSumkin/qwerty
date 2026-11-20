using System;
using System.Collections.Generic;
using System.IO;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001939 RID: 6457
public static class ez2
{
	// Token: 0x060088FD RID: 35069 RVA: 0x00388BDC File Offset: 0x00386DDC
	public static bk3 b(string A_0)
	{
		return ez2.a(A_0, true);
	}

	// Token: 0x060088FE RID: 35070 RVA: 0x00388BE8 File Offset: 0x00386DE8
	public static T GetItemDefinition<T>(string path, bool logError = true) where T : bk3
	{
		czh.a(path, "path");
		bk3 bk = ez2.a(path, logError);
		if (bk == null)
		{
			if (logError)
			{
				dux.b(LogSeverity.Error, "Library item definition not found: '{0}' ('{1}').", new object[]
				{
					path,
					typeof(T).FullName
				});
			}
			return default(T);
		}
		if (bk is T)
		{
			return (T)((object)bk);
		}
		if (logError)
		{
			dux.b(LogSeverity.Error, "Requested library item definition '{0}' was not of the requested type ('{1}').", new object[]
			{
				path,
				typeof(T).FullName
			});
		}
		return default(T);
	}

	// Token: 0x060088FF RID: 35071 RVA: 0x00388C90 File Offset: 0x00386E90
	public static T GetDefaultItemDefinition<T>() where T : bk3, new()
	{
		return Activator.CreateInstance<T>();
	}

	// Token: 0x06008900 RID: 35072 RVA: 0x00388C98 File Offset: 0x00386E98
	public static LibraryItemDefinitionProvider<T> CreateDefinitonProvider<T>(string path) where T : bk3, new()
	{
		czh.a(path, "path");
		return new LibraryItemDefinitionProvider<T>(path);
	}

	// Token: 0x06008901 RID: 35073 RVA: 0x00388CAC File Offset: 0x00386EAC
	public static void a()
	{
		d67 serviceOrThrow = bpo.GetServiceOrThrow<d67>();
		try
		{
			string text = Path.Combine(serviceOrThrow.lh().RootDirectory, "Rules\\Items");
			foreach (string path in Directory.GetFiles(text, "*.item", 1))
			{
				ez2.b(Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path)).Substring(text.Length).TrimStart(new char[]
				{
					'\\'
				}));
			}
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Failed to preload item definitions.", new object[0]);
		}
	}

	// Token: 0x06008902 RID: 35074 RVA: 0x00388D60 File Offset: 0x00386F60
	public static bk3 b(string A_0, bool A_1 = true)
	{
		d67 serviceOrThrow = bpo.GetServiceOrThrow<d67>();
		bk3 result = null;
		try
		{
			result = bk3.LoadFromBinaryFile<bk3>(Path.Combine(serviceOrThrow.lf(), Path.Combine(d5x.ai, A_0 + ".item")));
		}
		catch (Exception ex)
		{
			if (A_1)
			{
				dux.b(LogSeverity.Error, "Failed to load library item definition for item '{0}'. Exception: {1}", new object[]
				{
					A_0,
					ex.ToString()
				});
			}
		}
		return result;
	}

	// Token: 0x06008903 RID: 35075 RVA: 0x00388DDC File Offset: 0x00386FDC
	public static coh a(string A_0)
	{
		bk3 bk = ez2.b(A_0, true);
		if (bk != null)
		{
			Type type = typeof(LibraryItemDefinitionProvider<>).MakeGenericType(new Type[]
			{
				bk.GetType()
			});
			bit bit = Activator.CreateInstance(type, new object[]
			{
				A_0
			}) as bit;
			if (type != null)
			{
				Type type2 = bk3.a(bk.GetType());
				if (type2 != null)
				{
					return Activator.CreateInstance(type2, new object[]
					{
						bit
					}) as coh;
				}
			}
		}
		return null;
	}

	// Token: 0x06008904 RID: 35076 RVA: 0x00388E68 File Offset: 0x00387068
	private static bk3 a(string A_0, bool A_1 = true)
	{
		if (ez2.a.ContainsKey(A_0))
		{
			return ez2.a[A_0];
		}
		bk3 bk = ez2.b(A_0, A_1);
		ez2.a[A_0] = bk;
		return bk;
	}

	// Token: 0x0400369D RID: 13981
	private static Dictionary<string, bk3> a = new Dictionary<string, bk3>();
}

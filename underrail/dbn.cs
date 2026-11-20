using System;
using System.Collections.Generic;
using System.IO;
using Ouroboros.Core.Logging;

// Token: 0x020001CC RID: 460
public sealed class dbn
{
	// Token: 0x06000DBB RID: 3515 RVA: 0x0003967C File Offset: 0x0003787C
	public string b()
	{
		return this.a;
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00039684 File Offset: 0x00037884
	public dbn(string A_0)
	{
		this.a = A_0;
		this.a();
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x000396A4 File Offset: 0x000378A4
	public eva a(string A_0)
	{
		if (A_0 != null)
		{
			eva eva;
			this.b.TryGetValue(A_0, out eva);
			if (eva == null)
			{
				string key = A_0.ToLowerInvariant();
				this.b.TryGetValue(key, out eva);
				if (eva != null)
				{
					this.b[A_0] = eva;
				}
			}
			return eva;
		}
		return null;
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x000396F8 File Offset: 0x000378F8
	private void a()
	{
		bbp service = bpo.GetService<bbp>();
		if (service != null)
		{
			service.kv("Loading materialization metas");
		}
		cvq service2 = bpo.GetService<cvq>();
		if (Directory.Exists(this.a))
		{
			foreach (string text in Directory.GetFiles(this.a, "*.mu", 1))
			{
				eva value = dbn.b(text, service2);
				string key = Path.ChangeExtension(text.Substring(this.a.Length).TrimStart(new char[]
				{
					'\\'
				}).ToLowerInvariant(), null);
				this.b[key] = value;
			}
			foreach (string text2 in Directory.GetFiles(this.a, "*.mux", 1))
			{
				azj azj = dbn.a(text2, service2);
				string text3 = Path.ChangeExtension(text2.Substring(this.a.Length).TrimStart(new char[]
				{
					'\\'
				}).ToLowerInvariant(), null);
				text3 = text3.Replace("\\_agg", "");
				foreach (eva eva in azj.a)
				{
					string key2 = Path.Combine(text3, eva.a);
					this.b[key2] = eva;
				}
			}
		}
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00039880 File Offset: 0x00037A80
	private static eva b(string A_0, cvq A_1)
	{
		eva result;
		try
		{
			result = eoq.DeserializeFromBinaryFileCompressed<eva>(A_0, dds.a(), true);
		}
		catch (Exception ex)
		{
			if (A_1 != null && A_1.n8() && A_1.n9(LogSeverity.Error, 114))
			{
				string a_ = string.Format("[Materialization] - Failed to load materialization unit '{0}'. Exception: {1}.", A_0, ex.ToString());
				A_1.n7(LogSeverity.Error, 114, a_);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x000398F4 File Offset: 0x00037AF4
	private static azj a(string A_0, cvq A_1)
	{
		azj result;
		try
		{
			result = eoq.DeserializeFromBinaryFile<azj>(A_0, dds.a(), true);
		}
		catch (Exception ex)
		{
			if (A_1 != null && A_1.n8() && A_1.n9(LogSeverity.Error, 114))
			{
				string a_ = string.Format("[Materialization] - Failed to load materialization units complex '{0}'. Exception: {1}.", A_0, ex.ToString());
				A_1.n7(LogSeverity.Error, 114, a_);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x040007F4 RID: 2036
	private string a;

	// Token: 0x040007F5 RID: 2037
	private Dictionary<string, eva> b = new Dictionary<string, eva>();
}

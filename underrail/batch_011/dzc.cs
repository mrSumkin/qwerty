using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x02000149 RID: 329
[eiz("SE")]
[Serializable]
public class dzc : d55, ISerializable
{
	// Token: 0x06000825 RID: 2085 RVA: 0x000225E4 File Offset: 0x000207E4
	protected dzc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadCollection<esc>("SE:RA", ref this.a, A_0);
			di7.ReadDictionary<string, string>("SE:LT", ref this.b, A_0);
			if (ell.b() >= 42)
			{
				this.c = A_0.GetString("SE:UJ");
			}
		}
		else if (base.GetType() == typeof(dzc))
		{
			this.a = (Collection<esc>)A_0.GetValue("_ResultingActions", typeof(Collection<esc>));
			this.b = (Dictionary<string, string>)A_0.GetValue("_LocalizedTexts", typeof(Dictionary<string, string>));
		}
		else
		{
			this.a = (Collection<esc>)A_0.GetValue("StoryElement+_ResultingActions", typeof(Collection<esc>));
			this.b = (Dictionary<string, string>)A_0.GetValue("StoryElement+_LocalizedTexts", typeof(Dictionary<string, string>));
		}
		if (ell.b() >= 44)
		{
			this.d = A_0.GetInt32("SE:I");
		}
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0002271C File Offset: 0x0002091C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteCollection<esc>("SE:RA", this.a, info);
		di7.WriteDictionary<string, string>("SE:LT", this.b, info);
		info.AddValue("SE:UJ", this.c);
		info.AddValue("SE:I", this.d);
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00022778 File Offset: 0x00020978
	public Collection<esc> e()
	{
		return this.a;
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00022780 File Offset: 0x00020980
	public Dictionary<string, string> f()
	{
		return this.b;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00022788 File Offset: 0x00020988
	public string h()
	{
		return this.c;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00022790 File Offset: 0x00020990
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0002279C File Offset: 0x0002099C
	public string g()
	{
		string result;
		this.b.TryGetValue("English", out result);
		return result;
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x000227C0 File Offset: 0x000209C0
	public void b(string A_0)
	{
		this.b["English"] = A_0;
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x000227D4 File Offset: 0x000209D4
	protected dzc()
	{
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x000227F4 File Offset: 0x000209F4
	protected dzc(string A_0) : base(A_0)
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00022818 File Offset: 0x00020A18
	public virtual void b(bq8 A_0, bq8 A_1)
	{
		cvq cvq = dr3.e();
		foreach (esc esc in this.a)
		{
			try
			{
				PropertyCollection propertyCollection = new PropertyCollection();
				propertyCollection[e49.b] = this;
				esc.d5(A_0, new dpn(A_1, new bq8[]
				{
					propertyCollection
				}));
			}
			catch (Exception ex)
			{
				string str = string.Format("Error while executing action {0} on story element {1}. Exception: {2}", esc.Name, base.Name, ex.ToString());
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 115))
				{
					cvq.n7(LogSeverity.Warning, 115, "[Dialog Manager] " + str);
				}
			}
		}
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x00022908 File Offset: 0x00020B08
	public string a(string A_0, bq8 A_1, bq8 A_2)
	{
		czh.a(A_0, "culture");
		if (this.b.ContainsKey(A_0))
		{
			return eb2.a(A_1, A_2, this.b[A_0]);
		}
		cvq cvq = dr3.e();
		string str = "Error while trying to get text for culture " + A_0;
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 115))
		{
			cvq.n7(LogSeverity.Warning, 115, "[Dialog Manager] " + str);
		}
		return string.Empty;
	}

	// Token: 0x04000596 RID: 1430
	private Collection<esc> a = new Collection<esc>();

	// Token: 0x04000597 RID: 1431
	private Dictionary<string, string> b = new Dictionary<string, string>();

	// Token: 0x04000598 RID: 1432
	private new string c;

	// Token: 0x04000599 RID: 1433
	public int d;
}

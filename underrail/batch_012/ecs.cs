using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020004A4 RID: 1188
[eiz("RT")]
[Serializable]
public sealed class ecs : ISerializable
{
	// Token: 0x06001E30 RID: 7728 RVA: 0x000A8134 File Offset: 0x000A6334
	private ecs(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<dl6>("RT:L", ref this.a, A_0);
			if (ell.a() >= 325)
			{
				di7.ReadList<string>("RT:H", ref this.b, A_0);
				return;
			}
			this.b = new List<string>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(ecs))
			{
				this.a = (List<dl6>)A_0.GetValue("Lines", typeof(List<dl6>));
				return;
			}
			this.a = (List<dl6>)A_0.GetValue("RichText+Lines", typeof(List<dl6>));
			return;
		}
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x000A8200 File Offset: 0x000A6400
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<dl6>("RT:L", this.a, info);
		di7.WriteList<string>("RT:H", this.b, info);
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x000A8224 File Offset: 0x000A6424
	public ecs()
	{
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x000A8244 File Offset: 0x000A6444
	public ecs(IEnumerable<dl6> A_0)
	{
		czh.a(A_0, "lines");
		this.a.AddRange(A_0);
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x000A827C File Offset: 0x000A647C
	public List<ecs> a(int A_0, int A_1)
	{
		return e22.a(this, A_0, A_1);
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x000A8288 File Offset: 0x000A6488
	public dn3 b()
	{
		return e22.a(this);
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000A8294 File Offset: 0x000A6494
	public string a()
	{
		string text = "";
		foreach (dl6 dl in this.a)
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += " ";
			}
			foreach (bph bph in dl.a)
			{
				text += bph.b;
			}
		}
		return text;
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x000A8350 File Offset: 0x000A6550
	public static ecs a(string A_0, Color A_1, string A_2)
	{
		bph item = new bph(new d22(A_0, A_1), A_2, null);
		dl6 dl = new dl6();
		dl.a.Add(item);
		return new ecs
		{
			a = 
			{
				dl
			}
		};
	}

	// Token: 0x0400134C RID: 4940
	public List<dl6> a = new List<dl6>();

	// Token: 0x0400134D RID: 4941
	public List<string> b = new List<string>();
}

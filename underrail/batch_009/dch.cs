using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001042 RID: 4162
[eiz("ABEJ")]
[Serializable]
public sealed class dch : cze, ISerializable
{
	// Token: 0x0600561D RID: 22045 RVA: 0x0025E098 File Offset: 0x0025C298
	private dch(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("ABEJ:RC", ref this.a, A_0);
		di7.ReadList<Guid?>("ABEJ:I", ref this.b, A_0);
		this.c = A_0.GetString("ABEJ:A");
	}

	// Token: 0x0600561E RID: 22046 RVA: 0x0025E0F8 File Offset: 0x0025C2F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("ABEJ:RC", this.a, info);
		di7.WriteList<Guid?>("ABEJ:I", this.b, info);
		info.AddValue("ABEJ:A", this.c);
	}

	// Token: 0x0600561F RID: 22047 RVA: 0x0025E138 File Offset: 0x0025C338
	public List<string> b()
	{
		return this.a;
	}

	// Token: 0x06005620 RID: 22048 RVA: 0x0025E140 File Offset: 0x0025C340
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x0025E14C File Offset: 0x0025C34C
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x0025E154 File Offset: 0x0025C354
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x0025E160 File Offset: 0x0025C360
	public List<Guid?> c()
	{
		return this.b;
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x0025E168 File Offset: 0x0025C368
	public void a(List<Guid?> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x0025E174 File Offset: 0x0025C374
	public dch()
	{
	}

	// Token: 0x06005626 RID: 22054 RVA: 0x0025E194 File Offset: 0x0025C394
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		List<c5x> list = new List<c5x>();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (Enumerable.Any<Guid?>(this.b))
		{
			aud aud = null;
			if (this.c != null)
			{
				b4b serviceOrThrow2 = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow2.yn() != null && serviceOrThrow2.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow2.yn().Zones[0].n(this.c);
				}
			}
			else if (serviceOrThrow.aqu().v() != null)
			{
				aud = serviceOrThrow.aqu().v().b().Area;
			}
			if (aud != null)
			{
				foreach (Guid? guid in this.c())
				{
					Guid value = guid.Value;
					list.Add(new ar7(value, aud).ao() as c5x);
				}
			}
		}
		if (Enumerable.Any<string>(this.a))
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				List<b0b> list2 = d.ab2(this.a);
				list.AddRange(Enumerable.OfType<c5x>(list2));
				foreach (b0b b0b in list2)
				{
					((c5x)b0b).RemoveAspect<e3l>();
				}
			}
		}
		if (Enumerable.Any<c5x>(list))
		{
			foreach (c5x a_ in list)
			{
				dm0.a(a_);
			}
		}
	}

	// Token: 0x040022FA RID: 8954
	private new List<string> a = new List<string>();

	// Token: 0x040022FB RID: 8955
	private List<Guid?> b = new List<Guid?>();

	// Token: 0x040022FC RID: 8956
	private string c;
}

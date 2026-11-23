using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Game.Fragments;

// Token: 0x020006B2 RID: 1714
[eiz("RDFD")]
[Serializable]
public sealed class cl3 : b58
{
	// Token: 0x06002C6F RID: 11375 RVA: 0x000FEA70 File Offset: 0x000FCC70
	private cl3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("RDFD:C", ref this.a, A_0);
		this.b = (DungeonEntrance)A_0.GetValue("RDFD:E", typeof(DungeonEntrance));
		this.c = (A_0.GetValue("RDFD:L", typeof(int?)) as int?);
		if (ell.a() >= 533)
		{
			this.d = A_0.GetString("RDFD:ES");
			this.e = A_0.GetString("RDFD:VS");
			this.f = A_0.GetString("RDFD:I");
			this.g = A_0.GetString("RDFD:W");
		}
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x000FEB3C File Offset: 0x000FCD3C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("RDFD:C", this.a, info);
		info.AddValue("RDFD:E", this.b);
		info.AddValue("RDFD:L", this.c);
		info.AddValue("RDFD:ES", this.d);
		info.AddValue("RDFD:VS", this.e);
		info.AddValue("RDFD:I", this.f);
		info.AddValue("RDFD:W", this.g);
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x000FEBD4 File Offset: 0x000FCDD4
	public List<string> d()
	{
		return this.a;
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x000FEBDC File Offset: 0x000FCDDC
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x000FEBE8 File Offset: 0x000FCDE8
	public DungeonEntrance e()
	{
		return this.b;
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x000FEBF0 File Offset: 0x000FCDF0
	public void a(DungeonEntrance A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x000FEBFC File Offset: 0x000FCDFC
	public int? b()
	{
		return this.c;
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x000FEC04 File Offset: 0x000FCE04
	public void a(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x000FEC10 File Offset: 0x000FCE10
	public string a()
	{
		return this.d;
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x000FEC18 File Offset: 0x000FCE18
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002C79 RID: 11385 RVA: 0x000FEC24 File Offset: 0x000FCE24
	public string g()
	{
		return this.e;
	}

	// Token: 0x06002C7A RID: 11386 RVA: 0x000FEC2C File Offset: 0x000FCE2C
	public void d(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x000FEC38 File Offset: 0x000FCE38
	public string f()
	{
		return this.f;
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x000FEC40 File Offset: 0x000FCE40
	public void b(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x000FEC4C File Offset: 0x000FCE4C
	public string c()
	{
		return this.g;
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x000FEC54 File Offset: 0x000FCE54
	public void c(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06002C7F RID: 11391 RVA: 0x000FEC60 File Offset: 0x000FCE60
	public cl3()
	{
	}

	// Token: 0x06002C80 RID: 11392 RVA: 0x000FEC74 File Offset: 0x000FCE74
	public override void afz(cyt A_0)
	{
		base.afz(A_0);
		vl vl = a4i.a(A_0, this);
		A_0.r()[string.Format("dungeon_{0}", vl.Id)] = true;
		A_0.r()[string.Format("dungeon_{0}_exitLocale", vl.Id)] = this.f;
		A_0.r()[string.Format("dungeon_{0}_exitWaypoint", vl.Id)] = this.g;
		A_0.r()[string.Format("dungeon_{0}_entrance", vl.Id)] = this.b;
		if (!string.IsNullOrEmpty(base.o()))
		{
			A_0.r()[string.Format("dungeon_{0}_elDesc", vl.Id)] = A_0.r().GetClassPropertyValue<string>(string.Format("dungeon_{0}_elDesc", base.o()));
			A_0.r()[string.Format("dungeon_{0}_vlDesc", vl.Id)] = A_0.r().GetClassPropertyValue<string>(string.Format("dungeon_{0}_vlDesc", base.o()));
			A_0.r()[string.Format("dungeon_{0}_sourceLocale", vl.Id)] = A_0.r().GetClassPropertyValue<string>(string.Format("dungeon_{0}_sourceLocale", base.o()));
		}
		else
		{
			A_0.r()[string.Format("dungeon_{0}_sourceLocale", vl.Id)] = this.f;
			A_0.r()[string.Format("dungeon_{0}_elDesc", vl.Id)] = this.d;
			A_0.r()[string.Format("dungeon_{0}_vlDesc", vl.Id)] = this.e;
		}
		A_0.r()[string.Format("frag_{0}_dungeonLocale", base.m())] = vl.Id;
		ap.a(A_0, string.Format("dungeon_{0}_", vl.Id), vl.Properties);
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x000FEE70 File Offset: 0x000FD070
	public override bool af0(cyt A_0)
	{
		if (!base.af0(A_0))
		{
			return false;
		}
		if (string.IsNullOrEmpty(this.f))
		{
			return false;
		}
		alg alg = A_0.a(this.f, false);
		if (alg != null && alg.a)
		{
			return false;
		}
		List<vl> list = a4i.b(A_0, this);
		return list != null && list.Count != 0;
	}

	// Token: 0x04001935 RID: 6453
	private List<string> a = new List<string>();

	// Token: 0x04001936 RID: 6454
	private DungeonEntrance b;

	// Token: 0x04001937 RID: 6455
	private int? c;

	// Token: 0x04001938 RID: 6456
	private string d;

	// Token: 0x04001939 RID: 6457
	private string e;

	// Token: 0x0400193A RID: 6458
	private string f;

	// Token: 0x0400193B RID: 6459
	private string g;
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200026C RID: 620
[eiz("AL")]
[Serializable]
public sealed class cpe : ISerializable
{
	// Token: 0x06001247 RID: 4679 RVA: 0x0004B88C File Offset: 0x00049A8C
	private cpe(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("AL:AI", typeof(Guid));
			di7.ReadList<b0b>("AL:E", ref this.b, A_0);
			di7.ReadList<e4b>("AL:SLA", ref this.c, A_0);
			di7.ReadList<cno>("AL:D", ref this.d, A_0);
			di7.ReadList<ya>("AL:T", ref this.e, A_0);
			return;
		}
		if (base.GetType() == typeof(cpe))
		{
			this.a = (Guid)A_0.GetValue("_AreaId", typeof(Guid));
			this.b = (List<b0b>)A_0.GetValue("_Entities", typeof(List<b0b>));
			this.c = (List<e4b>)A_0.GetValue("_SoftLightAreas", typeof(List<e4b>));
			this.d = (List<cno>)A_0.GetValue("_Divinations", typeof(List<cno>));
			this.e = (List<ya>)A_0.GetValue("_Triggers", typeof(List<ya>));
			return;
		}
		this.a = (Guid)A_0.GetValue("AreaLayer+_AreaId", typeof(Guid));
		this.b = (List<b0b>)A_0.GetValue("AreaLayer+_Entities", typeof(List<b0b>));
		this.c = (List<e4b>)A_0.GetValue("AreaLayer+_SoftLightAreas", typeof(List<e4b>));
		this.d = (List<cno>)A_0.GetValue("AreaLayer+_Divinations", typeof(List<cno>));
		this.e = (List<ya>)A_0.GetValue("AreaLayer+_Triggers", typeof(List<ya>));
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x0004BA98 File Offset: 0x00049C98
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AL:AI", this.a);
		di7.WriteList<b0b>("AL:E", this.b, info);
		di7.WriteList<e4b>("AL:SLA", this.c, info);
		di7.WriteList<cno>("AL:D", this.d, info);
		di7.WriteList<ya>("AL:T", this.e, info);
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06001249 RID: 4681 RVA: 0x0004BB00 File Offset: 0x00049D00
	public Guid AreaId
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x0600124A RID: 4682 RVA: 0x0004BB08 File Offset: 0x00049D08
	public bool IsEmpty
	{
		get
		{
			return this.b.Count == 0 && this.c.Count == 0 && this.d.Count == 0;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600124B RID: 4683 RVA: 0x0004BB3C File Offset: 0x00049D3C
	public List<b0b> Entities
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600124C RID: 4684 RVA: 0x0004BB44 File Offset: 0x00049D44
	public List<e4b> SoftLightAreas
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600124D RID: 4685 RVA: 0x0004BB4C File Offset: 0x00049D4C
	public List<cno> Divinations
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600124E RID: 4686 RVA: 0x0004BB54 File Offset: 0x00049D54
	public List<ya> Triggers
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x0004BB5C File Offset: 0x00049D5C
	public cpe()
	{
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x0004BB94 File Offset: 0x00049D94
	public static cpe a(aud A_0, int A_1)
	{
		czh.a(A_0, "area");
		cpe cpe = new cpe();
		cpe.a = A_0.qe();
		foreach (e4b e4b in new List<e4b>(A_0.SoftLightAreas))
		{
			if (e4b.m4() == A_1)
			{
				A_0.SoftLightAreas.c(e4b);
				cpe.SoftLightAreas.Add(e4b);
			}
		}
		foreach (cno cno in new List<cno>(A_0.Divinations))
		{
			if (cno.m4() == A_1)
			{
				A_0.Divinations.c(cno);
				cpe.Divinations.Add(cno);
			}
		}
		foreach (ya ya in new List<ya>(A_0.Triggers))
		{
			if (ya.Layer == A_1)
			{
				ya.o();
				cpe.Triggers.Add(ya);
			}
		}
		foreach (b0b b0b in new List<b0b>(A_0.Entities))
		{
			if (b0b.Layer == A_1)
			{
				b0b.an();
				cpe.Entities.Add(b0b);
			}
		}
		return cpe;
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x0004BD74 File Offset: 0x00049F74
	public static cpe a(aud A_0, int A_1, List<afo> A_2)
	{
		czh.a(A_0, "area");
		cpe cpe = new cpe();
		cpe.a = A_0.qe();
		foreach (e4b e4b in new List<e4b>(A_0.SoftLightAreas))
		{
			e4b.m4();
		}
		foreach (cno cno in new List<cno>(A_0.Divinations))
		{
			cno.m4();
		}
		foreach (ya ya in new List<ya>(A_0.Triggers))
		{
			ya.Layer;
		}
		foreach (b0b b0b in new List<b0b>(A_0.Entities))
		{
			if (b0b.Layer == A_1)
			{
				A_2.Add(afo.a(b0b));
				cpe.Entities.Add(b0b);
			}
		}
		return cpe;
	}

	// Token: 0x04000A21 RID: 2593
	private Guid a;

	// Token: 0x04000A22 RID: 2594
	private List<b0b> b = new List<b0b>();

	// Token: 0x04000A23 RID: 2595
	private List<e4b> c = new List<e4b>();

	// Token: 0x04000A24 RID: 2596
	private List<cno> d = new List<cno>();

	// Token: 0x04000A25 RID: 2597
	private List<ya> e = new List<ya>();
}

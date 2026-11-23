using System;
using System.Runtime.Serialization;

// Token: 0x02001B40 RID: 6976
[eiz("ASE")]
[Serializable]
public sealed class uj : els, ISerializable
{
	// Token: 0x060096DC RID: 38620 RVA: 0x003AF360 File Offset: 0x003AD560
	private uj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetSingle("ASE:MSI");
		this.c = A_0.GetSingle("ASE:ARTD");
		this.d = A_0.GetSingle("ASE:DAEI");
		this.f = A_0.GetInt32("ASE:EFT");
		this.e = A_0.GetInt32("ASE:A");
		this.g = A_0.GetInt32("ASE:S");
	}

	// Token: 0x060096DD RID: 38621 RVA: 0x003AF3DC File Offset: 0x003AD5DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ASE:MSI", this.b);
		info.AddValue("ASE:ARTD", this.c);
		info.AddValue("ASE:DAEI", this.d);
		info.AddValue("ASE:EFT", this.f);
		info.AddValue("ASE:A", this.e);
		info.AddValue("ASE:S", this.g);
	}

	// Token: 0x060096DE RID: 38622 RVA: 0x003AF458 File Offset: 0x003AD658
	public float c()
	{
		return this.b;
	}

	// Token: 0x060096DF RID: 38623 RVA: 0x003AF460 File Offset: 0x003AD660
	public float d()
	{
		return this.c;
	}

	// Token: 0x060096E0 RID: 38624 RVA: 0x003AF468 File Offset: 0x003AD668
	public int a()
	{
		return this.e;
	}

	// Token: 0x060096E1 RID: 38625 RVA: 0x003AF470 File Offset: 0x003AD670
	public int b()
	{
		return this.f;
	}

	// Token: 0x060096E2 RID: 38626 RVA: 0x003AF478 File Offset: 0x003AD678
	public void a(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060096E3 RID: 38627 RVA: 0x003AF484 File Offset: 0x003AD684
	public uj(float A_0, float A_1, float A_2, int A_3, int A_4, int A_5, int A_6) : base(uj.a, "Прилив адреналина", ci8.b)
	{
		base.Duration = A_3;
		base.Icon = "Status.Adrenaline";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.ExpiredAction = "AdrenalineExpiresAction";
		base.RemovedAction = "AdrenalineExpiresAction";
		this.g = A_6;
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
		this.f = A_4;
		this.e = A_5;
		base.StaticEffects.Add(new ax6("Strength", this.g));
		base.StaticEffects.Add(new i0(this.b, false, false, false));
		base.StaticEffects.Add(new bjo(-this.c, 0, null));
		base.StaticEffects.Add(new d19(this.d)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new e15(this.d)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new d9(this.e, false, false));
	}

	// Token: 0x060096E4 RID: 38628 RVA: 0x003AF5B0 File Offset: 0x003AD7B0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Adrenaline", new object[]
		{
			this.e,
			(int)(this.d * 100f),
			this.g
		});
	}

	// Token: 0x04003A09 RID: 14857
	public new static readonly string a = "adrenaline";

	// Token: 0x04003A0A RID: 14858
	private float b;

	// Token: 0x04003A0B RID: 14859
	private new float c;

	// Token: 0x04003A0C RID: 14860
	private new float d;

	// Token: 0x04003A0D RID: 14861
	private new int e;

	// Token: 0x04003A0E RID: 14862
	private int f;

	// Token: 0x04003A0F RID: 14863
	private int g;
}

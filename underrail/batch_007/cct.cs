using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001110 RID: 4368
[eiz("SYJ")]
[Serializable]
public sealed class cct : cze
{
	// Token: 0x06005CF4 RID: 23796 RVA: 0x0027A1C4 File Offset: 0x002783C4
	private cct(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SYJ:T");
		this.b = (bvl)A_0.GetValue("SYJ:S", typeof(bvl));
		this.c = A_0.GetBoolean("SYJ:I");
		this.d = (A_0.GetValue("SYJ:C", typeof(Color?)) as Color?);
	}

	// Token: 0x06005CF5 RID: 23797 RVA: 0x0027A248 File Offset: 0x00278448
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SYJ:T", this.a);
		info.AddValue("SYJ:S", this.b);
		info.AddValue("SYJ:I", this.c);
		info.AddValue("SYJ:C", this.d);
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x0027A2AC File Offset: 0x002784AC
	// (set) Token: 0x06005CF7 RID: 23799 RVA: 0x0027A2B4 File Offset: 0x002784B4
	public string Text
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x0027A2C0 File Offset: 0x002784C0
	// (set) Token: 0x06005CF9 RID: 23801 RVA: 0x0027A2C8 File Offset: 0x002784C8
	public bool Interrupt
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06005CFA RID: 23802 RVA: 0x0027A2D4 File Offset: 0x002784D4
	// (set) Token: 0x06005CFB RID: 23803 RVA: 0x0027A2DC File Offset: 0x002784DC
	public Color? OverrideTextColor
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06005CFC RID: 23804 RVA: 0x0027A2E8 File Offset: 0x002784E8
	// (set) Token: 0x06005CFD RID: 23805 RVA: 0x0027A2F0 File Offset: 0x002784F0
	public bvl Speaker
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06005CFE RID: 23806 RVA: 0x0027A2FC File Offset: 0x002784FC
	public cct()
	{
	}

	// Token: 0x06005CFF RID: 23807 RVA: 0x0027A30C File Offset: 0x0027850C
	public cct(string A_0, bool A_1, Color? A_2 = null, bvl A_3 = bvl.c)
	{
		this.a = A_0;
		this.c = A_1;
		this.d = A_2;
		this.b = A_3;
	}

	// Token: 0x06005D00 RID: 23808 RVA: 0x0027A33C File Offset: 0x0027853C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b = null;
		switch (this.b)
		{
		case bvl.b:
			b0b = A_0;
			break;
		case bvl.c:
			b0b = A_1;
			break;
		case bvl.d:
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				b0b = serviceOrThrow.aqu().v().b();
			}
			break;
		}
		}
		if (b0b != null)
		{
			c0s aspect = b0b.GetAspect<c0s>();
			if (aspect != null)
			{
				aspect.a(this.a, this.c, this.d, null);
			}
		}
	}

	// Token: 0x04002517 RID: 9495
	private new string a;

	// Token: 0x04002518 RID: 9496
	private bvl b = bvl.c;

	// Token: 0x04002519 RID: 9497
	private bool c;

	// Token: 0x0400251A RID: 9498
	private Color? d;
}

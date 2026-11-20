using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001CF2 RID: 7410
[eiz("BARX")]
[Serializable]
public sealed class dec : brl, ICloneable
{
	// Token: 0x0600A2C1 RID: 41665 RVA: 0x003E9E80 File Offset: 0x003E8080
	private dec(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (BaseAbilityEnum)A_0.GetValue("BARX:B", typeof(BaseAbilityEnum));
		this.c = A_0.GetInt32("BARX:M");
		this.b = A_0.GetBoolean("BARX:C");
	}

	// Token: 0x0600A2C2 RID: 41666 RVA: 0x003E9ED8 File Offset: 0x003E80D8
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("BARX:B", this.a);
		info.AddValue("BARX:M", this.c);
		info.AddValue("BARX:C", this.b);
	}

	// Token: 0x0600A2C3 RID: 41667 RVA: 0x003E9F28 File Offset: 0x003E8128
	public BaseAbilityEnum a()
	{
		return this.a;
	}

	// Token: 0x0600A2C4 RID: 41668 RVA: 0x003E9F30 File Offset: 0x003E8130
	public void a(BaseAbilityEnum A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2C5 RID: 41669 RVA: 0x003E9F3C File Offset: 0x003E813C
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600A2C6 RID: 41670 RVA: 0x003E9F44 File Offset: 0x003E8144
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600A2C7 RID: 41671 RVA: 0x003E9F50 File Offset: 0x003E8150
	public int c()
	{
		return this.c;
	}

	// Token: 0x0600A2C8 RID: 41672 RVA: 0x003E9F58 File Offset: 0x003E8158
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600A2C9 RID: 41673 RVA: 0x003E9F64 File Offset: 0x003E8164
	public override int og()
	{
		return Math.Max(1, (this.c - aiy.x + 1) * aiy.u);
	}

	// Token: 0x0600A2CA RID: 41674 RVA: 0x003E9F80 File Offset: 0x003E8180
	public dec()
	{
	}

	// Token: 0x0600A2CB RID: 41675 RVA: 0x003E9F88 File Offset: 0x003E8188
	public dec(BaseAbilityEnum A_0, int A_1, bool A_2 = false)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
	}

	// Token: 0x0600A2CC RID: 41676 RVA: 0x003E9FA8 File Offset: 0x003E81A8
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.BaseAbilities == null)
		{
			return false;
		}
		to to = A_0.BaseAbilities.a(this.a.ToString());
		if (to == null)
		{
			return false;
		}
		if (this.b)
		{
			return to.g() >= this.c;
		}
		return to.f() >= this.c;
	}

	// Token: 0x0600A2CD RID: 41677 RVA: 0x003EA020 File Offset: 0x003E8220
	public override string ToString()
	{
		return dh9.a(this.a) + " " + this.c.ToString();
	}

	// Token: 0x0600A2CE RID: 41678 RVA: 0x003EA048 File Offset: 0x003E8248
	public object Clone()
	{
		return new dec
		{
			a = this.a,
			b = this.b,
			c = this.c
		};
	}

	// Token: 0x04003E4C RID: 15948
	private BaseAbilityEnum a;

	// Token: 0x04003E4D RID: 15949
	private bool b;

	// Token: 0x04003E4E RID: 15950
	private int c;
}

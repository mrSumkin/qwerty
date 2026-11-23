using System;
using System.Runtime.Serialization;

// Token: 0x02001CF1 RID: 7409
[eiz("APSRX")]
[Serializable]
public sealed class aki : brl, ICloneable
{
	// Token: 0x0600A2B5 RID: 41653 RVA: 0x003E9CAC File Offset: 0x003E7EAC
	private aki(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("APSRX:M");
		this.b = A_0.GetBoolean("APSRX:C");
	}

	// Token: 0x0600A2B6 RID: 41654 RVA: 0x003E9CD8 File Offset: 0x003E7ED8
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("APSRX:M", this.a);
		info.AddValue("APSRX:C", this.b);
	}

	// Token: 0x0600A2B7 RID: 41655 RVA: 0x003E9D04 File Offset: 0x003E7F04
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600A2B8 RID: 41656 RVA: 0x003E9D0C File Offset: 0x003E7F0C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2B9 RID: 41657 RVA: 0x003E9D18 File Offset: 0x003E7F18
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600A2BA RID: 41658 RVA: 0x003E9D20 File Offset: 0x003E7F20
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600A2BB RID: 41659 RVA: 0x003E9D2C File Offset: 0x003E7F2C
	public override int og()
	{
		return Math.Max(1, (this.a - aiy.aj * (aiy.ak - 1)) / aiy.aj);
	}

	// Token: 0x0600A2BC RID: 41660 RVA: 0x003E9D50 File Offset: 0x003E7F50
	public aki()
	{
	}

	// Token: 0x0600A2BD RID: 41661 RVA: 0x003E9D58 File Offset: 0x003E7F58
	public aki(int A_0, bool A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600A2BE RID: 41662 RVA: 0x003E9D70 File Offset: 0x003E7F70
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		foreach (Type a_ in new Type[]
		{
			typeof(rs),
			typeof(dql),
			typeof(fd),
			typeof(p5)
		})
		{
			csn csn = A_0.Skills.b(a_);
			if (csn != null && (csn.DLC == null || dk2.b(csn.DLC)))
			{
				if (this.b)
				{
					if (csn.g() >= this.a)
					{
						return true;
					}
				}
				else if (csn.f() >= this.a)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600A2BF RID: 41663 RVA: 0x003E9E3C File Offset: 0x003E803C
	public override string ToString()
	{
		return qv.b("Skills/AnyPsi") + " " + this.a.ToString();
	}

	// Token: 0x0600A2C0 RID: 41664 RVA: 0x003E9E60 File Offset: 0x003E8060
	public object Clone()
	{
		return new aki
		{
			b = this.b,
			a = this.a
		};
	}

	// Token: 0x04003E4A RID: 15946
	private int a;

	// Token: 0x04003E4B RID: 15947
	private bool b;
}

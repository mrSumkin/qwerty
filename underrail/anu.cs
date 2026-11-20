using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001CF6 RID: 7414
[eiz("SKRX2")]
[Serializable]
public sealed class anu : brl, ICloneable
{
	// Token: 0x0600A2EB RID: 41707 RVA: 0x003EA5BC File Offset: 0x003E87BC
	private anu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<SkillEnum>("SKRX2:S", ref this.b, A_0);
		this.a = A_0.GetInt32("SKRX2:M");
		this.c = A_0.GetBoolean("SKRX2:C");
	}

	// Token: 0x0600A2EC RID: 41708 RVA: 0x003EA610 File Offset: 0x003E8810
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		di7.WriteList<SkillEnum>("SKRX2:S", this.b, info);
		info.AddValue("SKRX2:M", this.a);
		info.AddValue("SKRX2:C", this.c);
	}

	// Token: 0x0600A2ED RID: 41709 RVA: 0x003EA650 File Offset: 0x003E8850
	public List<SkillEnum> a()
	{
		return this.b;
	}

	// Token: 0x0600A2EE RID: 41710 RVA: 0x003EA658 File Offset: 0x003E8858
	public void a(List<SkillEnum> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600A2EF RID: 41711 RVA: 0x003EA664 File Offset: 0x003E8864
	public int b()
	{
		return this.a;
	}

	// Token: 0x0600A2F0 RID: 41712 RVA: 0x003EA66C File Offset: 0x003E886C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2F1 RID: 41713 RVA: 0x003EA678 File Offset: 0x003E8878
	public bool c()
	{
		return this.c;
	}

	// Token: 0x0600A2F2 RID: 41714 RVA: 0x003EA680 File Offset: 0x003E8880
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600A2F3 RID: 41715 RVA: 0x003EA68C File Offset: 0x003E888C
	public override int og()
	{
		return Math.Max(1, (this.a - aiy.aj * (aiy.ak - 1)) / aiy.aj);
	}

	// Token: 0x0600A2F4 RID: 41716 RVA: 0x003EA6B0 File Offset: 0x003E88B0
	public anu()
	{
	}

	// Token: 0x0600A2F5 RID: 41717 RVA: 0x003EA6C4 File Offset: 0x003E88C4
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		foreach (SkillEnum skillEnum in this.b)
		{
			string a_ = skillEnum.ToString().a();
			csn csn = A_0.Skills.b(a_);
			if (csn != null)
			{
				if (this.c)
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

	// Token: 0x0600A2F6 RID: 41718 RVA: 0x003EA788 File Offset: 0x003E8988
	public override string ToString()
	{
		string str = "";
		for (int i = 0; i < this.b.Count; i++)
		{
			if (i != 0)
			{
				if (i == this.b.Count - 1)
				{
					str = str + " " + dh9.c("or") + " ";
				}
				else
				{
					str += ", ";
				}
			}
			str += dh9.a(this.b[i]);
		}
		return str + " " + this.a.ToString();
	}

	// Token: 0x0600A2F7 RID: 41719 RVA: 0x003EA82C File Offset: 0x003E8A2C
	public object Clone()
	{
		return new anu
		{
			c = this.c,
			a = this.a,
			b = new List<SkillEnum>(this.b)
		};
	}

	// Token: 0x04003E52 RID: 15954
	private int a;

	// Token: 0x04003E53 RID: 15955
	private List<SkillEnum> b = new List<SkillEnum>();

	// Token: 0x04003E54 RID: 15956
	private bool c;
}

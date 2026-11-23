using System;

// Token: 0x0200070C RID: 1804
public abstract class eny : d6i
{
	// Token: 0x06002EC7 RID: 11975 RVA: 0x00108AF8 File Offset: 0x00106CF8
	public virtual void mw(coh A_0, int A_1)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			A_0.Definition.g(A_1);
			A_0.Durability = (double)A_0.MaxDurability;
		}
	}

	// Token: 0x06002EC8 RID: 11976
	public abstract string mt();

	// Token: 0x06002EC9 RID: 11977 RVA: 0x00108B30 File Offset: 0x00106D30
	public virtual bool atv()
	{
		return true;
	}

	// Token: 0x06002ECA RID: 11978 RVA: 0x00108B38 File Offset: 0x00106D38
	public virtual int? mu()
	{
		return null;
	}

	// Token: 0x06002ECB RID: 11979 RVA: 0x00108B50 File Offset: 0x00106D50
	public virtual int? mv()
	{
		return null;
	}

	// Token: 0x06002ECC RID: 11980 RVA: 0x00108B68 File Offset: 0x00106D68
	protected int b(int A_0)
	{
		int num = A_0;
		if (this.mu() != null && num < this.mu().Value)
		{
			num = this.mu().Value;
		}
		if (this.mv() != null && num > this.mv().Value)
		{
			num = this.mv().Value;
		}
		return num;
	}

	// Token: 0x06002ECD RID: 11981 RVA: 0x00108BE4 File Offset: 0x00106DE4
	protected void a(bk3 A_0, int A_1, double A_2)
	{
		if (A_0 != null && A_0.bf() != null)
		{
			double num = 1.0 + this.a(A_1);
			A_0.b(new double?(A_0.bf().Value * num));
		}
	}

	// Token: 0x06002ECE RID: 11982 RVA: 0x00108C38 File Offset: 0x00106E38
	protected double a(int A_0)
	{
		if (this.mv() != null)
		{
			double num = (double)Math.Max(1, this.mv().Value - this.mu().GetValueOrDefault());
			return (double)Math.Max(0, A_0 - this.mu().GetValueOrDefault()) / num;
		}
		return 0.5;
	}
}

using System;
using System.Collections.Generic;

// Token: 0x02001E2E RID: 7726
public sealed class b4k : brl
{
	// Token: 0x0600AB34 RID: 43828 RVA: 0x003F5EA0 File Offset: 0x003F40A0
	public List<Type> a()
	{
		return this.a;
	}

	// Token: 0x0600AB35 RID: 43829 RVA: 0x003F5EA8 File Offset: 0x003F40A8
	public override int og()
	{
		int num = 1;
		foreach (Type a_ in this.a)
		{
			ai8 ai = ck.b(a_);
			if (ai != null)
			{
				num = Math.Max(num, ai.MinimalLevel);
			}
		}
		return num;
	}

	// Token: 0x0600AB36 RID: 43830 RVA: 0x003F5F18 File Offset: 0x003F4118
	public b4k(params Type[] A_0)
	{
		czh.a(A_0, "candidateFeats");
		if (A_0.Length == 0)
		{
			throw new ArgumentException("Candidate feat array was empty. FeatRequirement requires at least one candidate feat.", "candidateFeats");
		}
		this.a = new List<Type>(A_0);
	}

	// Token: 0x0600AB37 RID: 43831 RVA: 0x003F5F50 File Offset: 0x003F4150
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.Feats != null)
		{
			foreach (Type a_ in this.a)
			{
				if (A_0.Feats.c(a_))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600AB38 RID: 43832 RVA: 0x003F5FD4 File Offset: 0x003F41D4
	public override string ToString()
	{
		string text = dh9.c("Feat") + ": ";
		for (int i = 0; i < this.a.Count; i++)
		{
			if (i != 0)
			{
				if (i == this.a.Count - 1)
				{
					text = text + " " + dh9.c("or") + " ";
				}
				else
				{
					text += ", ";
				}
			}
			text += ai8.b(this.a[i]);
		}
		return text;
	}

	// Token: 0x04003FEC RID: 16364
	private List<Type> a;
}

using System;
using System.Collections.Generic;

// Token: 0x02001DFD RID: 7677
public sealed class c2y : brl
{
	// Token: 0x0600A9F5 RID: 43509 RVA: 0x003F2CC0 File Offset: 0x003F0EC0
	public List<Type> a()
	{
		return this.a;
	}

	// Token: 0x0600A9F6 RID: 43510 RVA: 0x003F2CC8 File Offset: 0x003F0EC8
	public override int og()
	{
		return 1;
	}

	// Token: 0x0600A9F7 RID: 43511 RVA: 0x003F2CCC File Offset: 0x003F0ECC
	public c2y(params Type[] A_0)
	{
		czh.a(A_0, "candidateFeats");
		if (A_0.Length == 0)
		{
			throw new ArgumentException("Candidate feat array was empty. FeatRequirement requires at least one candidate feat.", "candidateFeats");
		}
		this.a = new List<Type>(A_0);
	}

	// Token: 0x0600A9F8 RID: 43512 RVA: 0x003F2D04 File Offset: 0x003F0F04
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.Feats != null)
		{
			foreach (Type a_ in this.a)
			{
				if (A_0.Feats.c(a_))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x0600A9F9 RID: 43513 RVA: 0x003F2D88 File Offset: 0x003F0F88
	public override string ToString()
	{
		string text;
		if (this.a.Count > 1)
		{
			text = dh9.c("RestrictedFeats");
		}
		else
		{
			text = dh9.c("RestrictedFeat");
		}
		text += ": ";
		for (int i = 0; i < this.a.Count; i++)
		{
			if (i != 0)
			{
				text += ", ";
				if (i == this.a.Count - 1)
				{
					text = text + dh9.c("and") + " ";
				}
			}
			text += ai8.b(this.a[i]);
		}
		return text;
	}

	// Token: 0x04003FA7 RID: 16295
	private List<Type> a;
}

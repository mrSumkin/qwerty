using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E30 RID: 7728
public sealed class bap : ValueBasedRequirement<int>
{
	// Token: 0x0600AB3D RID: 43837 RVA: 0x003F60D4 File Offset: 0x003F42D4
	public ReadOnlyCollection<Type> a()
	{
		return this.a.AsReadOnly();
	}

	// Token: 0x0600AB3E RID: 43838 RVA: 0x003F60E4 File Offset: 0x003F42E4
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600AB3F RID: 43839 RVA: 0x003F60EC File Offset: 0x003F42EC
	public override int og()
	{
		return Math.Max(1, (base.c() - aiy.aj * (aiy.ak - 1)) / aiy.aj);
	}

	// Token: 0x0600AB40 RID: 43840 RVA: 0x003F6110 File Offset: 0x003F4310
	public bap(int A_0, params Type[] A_1) : this(A_0, false, A_1)
	{
	}

	// Token: 0x0600AB41 RID: 43841 RVA: 0x003F611C File Offset: 0x003F431C
	public bap(int A_0, bool A_1, params Type[] A_2) : base(A_0)
	{
		czh.a(A_2, "candidateSkills");
		if (A_2.Length == 0)
		{
			throw new ArgumentException("Candidate skill array was empty. SkillRequirement requires at least one candidate skill.", "candidateSkills");
		}
		this.a = new List<Type>(A_2);
		this.b = A_1;
	}

	// Token: 0x0600AB42 RID: 43842 RVA: 0x003F615C File Offset: 0x003F435C
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		foreach (Type a_ in this.a)
		{
			if (ddv.a(a_))
			{
				csn csn = A_0.Skills.b(a_);
				if (csn != null)
				{
					if (this.b)
					{
						if (csn.g() >= base.c())
						{
							return true;
						}
					}
					else if (csn.f() >= base.c())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600AB43 RID: 43843 RVA: 0x003F6218 File Offset: 0x003F4418
	public override string ToString()
	{
		string str = "";
		List<Type> list = new List<Type>(this.a);
		for (int i = list.Count - 1; i >= 0; i--)
		{
			if (!ddv.a(list[i]))
			{
				list.RemoveAt(i);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (i != 0)
			{
				if (i == list.Count - 1)
				{
					str = str + " " + dh9.c("or") + " ";
				}
				else
				{
					str += ", ";
				}
			}
			str += ddv.b(list[i]);
		}
		return str + " " + base.c().ToString();
	}

	// Token: 0x04003FED RID: 16365
	private List<Type> a;

	// Token: 0x04003FEE RID: 16366
	private bool b;
}

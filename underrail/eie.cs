using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Token: 0x02001E0A RID: 7690
public abstract class eie : brl
{
	// Token: 0x0600AA49 RID: 43593 RVA: 0x003F3940 File Offset: 0x003F1B40
	public ReadOnlyCollection<Type> a()
	{
		return this.a.AsReadOnly();
	}

	// Token: 0x0600AA4A RID: 43594
	public abstract string aee();

	// Token: 0x0600AA4B RID: 43595 RVA: 0x003F3950 File Offset: 0x003F1B50
	protected eie(params Type[] A_0)
	{
		if (A_0 != null)
		{
			this.a = new List<Type>(A_0);
			return;
		}
		this.a = new List<Type>();
	}

	// Token: 0x0600AA4C RID: 43596 RVA: 0x003F3978 File Offset: 0x003F1B78
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		foreach (Type a_ in this.a)
		{
			if (this.aef(A_0, a_))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AA4D RID: 43597 RVA: 0x003F39EC File Offset: 0x003F1BEC
	public override string ToString()
	{
		string text = this.aee() + ": ";
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
			text += dgk.a(this.a[i]);
		}
		return text;
	}

	// Token: 0x0600AA4E RID: 43598
	protected abstract bool aef(efk A_0, Type A_1);

	// Token: 0x04003FBD RID: 16317
	private List<Type> a;
}

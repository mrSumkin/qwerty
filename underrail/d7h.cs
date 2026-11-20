using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001CF4 RID: 7412
[eiz("FTRX")]
[Serializable]
public sealed class d7h : brl, ICloneable
{
	// Token: 0x0600A2D8 RID: 41688 RVA: 0x003EA2C4 File Offset: 0x003E84C4
	private d7h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("FTRX:F", ref this.a, A_0);
	}

	// Token: 0x0600A2D9 RID: 41689 RVA: 0x003EA2EC File Offset: 0x003E84EC
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		di7.WriteList<string>("FTRX:F", this.a, info);
	}

	// Token: 0x0600A2DA RID: 41690 RVA: 0x003EA308 File Offset: 0x003E8508
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x0600A2DB RID: 41691 RVA: 0x003EA310 File Offset: 0x003E8510
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2DC RID: 41692 RVA: 0x003EA31C File Offset: 0x003E851C
	public override int og()
	{
		int num = 1;
		foreach (string a_ in this.a)
		{
			ai8 ai = ck.a(a_);
			if (ai != null)
			{
				num = Math.Max(num, ai.MinimalLevel);
			}
		}
		return num;
	}

	// Token: 0x0600A2DD RID: 41693 RVA: 0x003EA38C File Offset: 0x003E858C
	public d7h()
	{
	}

	// Token: 0x0600A2DE RID: 41694 RVA: 0x003EA3A0 File Offset: 0x003E85A0
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.Feats != null)
		{
			foreach (string a_ in this.a)
			{
				ai8 a_2 = ck.a(a_);
				if (A_0.Feats.a(a_2))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600A2DF RID: 41695 RVA: 0x003EA428 File Offset: 0x003E8628
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
			ai8 ai = ck.a(this.a[i]);
			if (ai != null)
			{
				text += ai8.a(ai);
			}
			else
			{
				text += "Unknown";
			}
		}
		return text;
	}

	// Token: 0x0600A2E0 RID: 41696 RVA: 0x003EA4E4 File Offset: 0x003E86E4
	public object Clone()
	{
		return new d7h
		{
			a = new List<string>(this.a)
		};
	}

	// Token: 0x04003E50 RID: 15952
	private List<string> a = new List<string>();
}

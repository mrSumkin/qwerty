using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001CF3 RID: 7411
[eiz("RFTRX")]
[Serializable]
public sealed class ad2 : brl, ICloneable
{
	// Token: 0x0600A2CF RID: 41679 RVA: 0x003EA074 File Offset: 0x003E8274
	private ad2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("RFTRX:F", ref this.a, A_0);
	}

	// Token: 0x0600A2D0 RID: 41680 RVA: 0x003EA09C File Offset: 0x003E829C
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		di7.WriteList<string>("RFTRX:F", this.a, info);
	}

	// Token: 0x0600A2D1 RID: 41681 RVA: 0x003EA0B8 File Offset: 0x003E82B8
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x0600A2D2 RID: 41682 RVA: 0x003EA0C0 File Offset: 0x003E82C0
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2D3 RID: 41683 RVA: 0x003EA0CC File Offset: 0x003E82CC
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

	// Token: 0x0600A2D4 RID: 41684 RVA: 0x003EA13C File Offset: 0x003E833C
	public ad2()
	{
	}

	// Token: 0x0600A2D5 RID: 41685 RVA: 0x003EA150 File Offset: 0x003E8350
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
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x0600A2D6 RID: 41686 RVA: 0x003EA1D8 File Offset: 0x003E83D8
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
		for (int i = 0; i < this.a.Count; i++)
		{
			if (i != 0)
			{
				if (i == this.a.Count - 1)
				{
					text = text + " " + dh9.c("and") + " ";
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

	// Token: 0x0600A2D7 RID: 41687 RVA: 0x003EA2AC File Offset: 0x003E84AC
	public object Clone()
	{
		return new ad2
		{
			a = new List<string>(this.a)
		};
	}

	// Token: 0x04003E4F RID: 15951
	private List<string> a = new List<string>();
}

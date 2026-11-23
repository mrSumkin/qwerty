using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000664 RID: 1636
[eiz("MCY")]
[Serializable]
public sealed class agn : ISerializable
{
	// Token: 0x0600298A RID: 10634 RVA: 0x000EC71C File Offset: 0x000EA91C
	private agn(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<int>("MCY:C", ref this.a, A_0);
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x000EC740 File Offset: 0x000EA940
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		di7.WriteList<int>("MCY:C", this.a, info);
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x000EC754 File Offset: 0x000EA954
	public agn(List<int> A_0)
	{
		this.a = new List<int>(A_0);
	}

	// Token: 0x0600298D RID: 10637 RVA: 0x000EC774 File Offset: 0x000EA974
	public agn()
	{
	}

	// Token: 0x0600298E RID: 10638 RVA: 0x000EC788 File Offset: 0x000EA988
	public void a(agn A_0)
	{
		foreach (int num in A_0.a)
		{
			if (num < 0)
			{
				if (this.a.Contains(-num))
				{
					this.a.Remove(-num);
				}
			}
			else if (!this.a.Contains(num))
			{
				this.a.Add(num);
			}
		}
	}

	// Token: 0x0600298F RID: 10639 RVA: 0x000EC824 File Offset: 0x000EAA24
	public override bool Equals(object obj)
	{
		agn agn = obj as agn;
		if (agn == null)
		{
			return false;
		}
		if (agn.a.Count != this.a.Count)
		{
			return false;
		}
		for (int i = 0; i < agn.a.Count; i++)
		{
			if (agn.a[i] != this.a[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x000EC898 File Offset: 0x000EAA98
	public override int GetHashCode()
	{
		int num = 0;
		for (int i = 0; i < this.a.Count; i++)
		{
			num += this.a[i] * 100;
		}
		return num;
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x000EC8D4 File Offset: 0x000EAAD4
	public void a()
	{
		for (int i = this.a.Count - 1; i >= 0; i--)
		{
			if (this.a[i] < 0)
			{
				this.a.RemoveAt(i);
			}
		}
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x000EC91C File Offset: 0x000EAB1C
	public string a(euk A_0)
	{
		string text = "";
		foreach (int num in this.a)
		{
			if (text != "")
			{
				text += " ";
			}
			if (num < 0)
			{
				text += "-";
			}
			text += A_0.c[Math.Abs(num)];
		}
		return text;
	}

	// Token: 0x040016A7 RID: 5799
	public List<int> a = new List<int>();
}

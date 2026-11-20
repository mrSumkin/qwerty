using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02000146 RID: 326
[eiz("BA")]
[Serializable]
public abstract class esc : ISerializable, c7m
{
	// Token: 0x0600080A RID: 2058 RVA: 0x00022244 File Offset: 0x00020444
	protected esc(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("BA:N");
			return;
		}
		if (base.GetType() == typeof(esc))
		{
			this.a = A_0.GetString("_Name");
			return;
		}
		this.a = A_0.GetString("BaseAction+_Name");
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x000222B0 File Offset: 0x000204B0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("BA:N", this.a);
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600080C RID: 2060 RVA: 0x000222C4 File Offset: 0x000204C4
	// (set) Token: 0x0600080D RID: 2061 RVA: 0x000222CC File Offset: 0x000204CC
	[Browsable(false)]
	public string Name
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x000222D8 File Offset: 0x000204D8
	public esc()
	{
		this.a = Guid.NewGuid().ToString();
	}

	// Token: 0x0600080F RID: 2063
	public abstract int d5(bq8 A_0, bq8 A_1);

	// Token: 0x06000810 RID: 2064 RVA: 0x00022304 File Offset: 0x00020504
	public virtual bool h5(string A_0, bool A_1)
	{
		return !string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00022338 File Offset: 0x00020538
	public override string ToString()
	{
		return base.GetType().Name;
	}

	// Token: 0x0400058F RID: 1423
	private string a;
}

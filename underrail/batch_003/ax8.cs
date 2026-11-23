using System;
using System.Runtime.Serialization;

// Token: 0x02000147 RID: 327
[eiz("A4")]
[Serializable]
public class ax8 : ISerializable
{
	// Token: 0x06000812 RID: 2066 RVA: 0x00022348 File Offset: 0x00020548
	protected ax8(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("A4:N");
			this.b = A_0.GetString("A4:P");
			return;
		}
		if (base.GetType() == typeof(ax8))
		{
			this.a = A_0.GetString("_Name");
			this.b = A_0.GetString("_Picture");
			return;
		}
		this.a = A_0.GetString("Actor+_Name");
		this.b = A_0.GetString("Actor+_Picture");
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x000223E8 File Offset: 0x000205E8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("A4:N", this.a);
		info.AddValue("A4:P", this.b);
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002240C File Offset: 0x0002060C
	// (set) Token: 0x06000815 RID: 2069 RVA: 0x00022414 File Offset: 0x00020614
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

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000816 RID: 2070 RVA: 0x00022420 File Offset: 0x00020620
	// (set) Token: 0x06000817 RID: 2071 RVA: 0x00022428 File Offset: 0x00020628
	public string Picture
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00022434 File Offset: 0x00020634
	public ax8(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04000590 RID: 1424
	private string a;

	// Token: 0x04000591 RID: 1425
	private string b;
}

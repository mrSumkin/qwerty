using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02000029 RID: 41
[eiz("A")]
[Serializable]
public abstract class cn7 : ISerializable
{
	// Token: 0x06000096 RID: 150 RVA: 0x00004698 File Offset: 0x00002898
	protected cn7(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (cuw)A_0.GetValue("A:C", typeof(cuw));
			return;
		}
		this.a = (A_0.GetValue("_Container", typeof(cuw)) as cuw);
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000046F8 File Offset: 0x000028F8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("A:C", this.a);
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000098 RID: 152 RVA: 0x0000470C File Offset: 0x0000290C
	// (set) Token: 0x06000099 RID: 153 RVA: 0x00004714 File Offset: 0x00002914
	[Browsable(false)]
	public cuw Container
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

	// Token: 0x0600009A RID: 154 RVA: 0x00004720 File Offset: 0x00002920
	protected cn7(cuw A_0)
	{
		czh.a(A_0, "container");
		this.a = A_0;
	}

	// Token: 0x04000131 RID: 305
	private cuw a;
}

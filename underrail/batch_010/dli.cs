using System;
using System.Runtime.Serialization;

// Token: 0x0200003B RID: 59
[eiz("E1")]
[Serializable]
public abstract class dli : c7t, a9q, ISerializable
{
	// Token: 0x060000A9 RID: 169 RVA: 0x00004C48 File Offset: 0x00002E48
	protected dli(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("E1:I", typeof(Guid));
			this.b = A_0.GetString("E1:N");
			return;
		}
		if (base.GetType() == typeof(dli))
		{
			this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.b = A_0.GetString("_Name");
			return;
		}
		this.a = (Guid)A_0.GetValue("Event+_Id", typeof(Guid));
		this.b = A_0.GetString("Event+_Name");
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00004D14 File Offset: 0x00002F14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("E1:I", this.a);
		info.AddValue("E1:N", this.b);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00004D40 File Offset: 0x00002F40
	public Guid qe()
	{
		return this.a;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00004D48 File Offset: 0x00002F48
	public string y8()
	{
		return this.b;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00004D50 File Offset: 0x00002F50
	protected dli(Guid A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00004D68 File Offset: 0x00002F68
	protected dli(string A_0) : this(Guid.NewGuid(), A_0)
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00004D78 File Offset: 0x00002F78
	protected dli() : this(null)
	{
	}

	// Token: 0x040001E3 RID: 483
	private Guid a;

	// Token: 0x040001E4 RID: 484
	private string b;
}

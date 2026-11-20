using System;
using System.Runtime.Serialization;

// Token: 0x020005EF RID: 1519
[eiz("DIC")]
[Serializable]
public sealed class d2y : dth, ISerializable
{
	// Token: 0x060027E2 RID: 10210 RVA: 0x000E7060 File Offset: 0x000E5260
	private d2y(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("DIC:C");
		if (ell.a() >= 665)
		{
			this.b = A_0.GetBoolean("DIC:I");
		}
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x000E709C File Offset: 0x000E529C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("DIC:C", this.a);
		info.AddValue("DIC:I", this.b);
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x000E70C0 File Offset: 0x000E52C0
	public string a()
	{
		return this.a;
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x000E70C8 File Offset: 0x000E52C8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060027E6 RID: 10214 RVA: 0x000E70D4 File Offset: 0x000E52D4
	public bool b()
	{
		return this.b;
	}

	// Token: 0x060027E7 RID: 10215 RVA: 0x000E70DC File Offset: 0x000E52DC
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060027E8 RID: 10216 RVA: 0x000E70E8 File Offset: 0x000E52E8
	public d2y()
	{
	}

	// Token: 0x060027E9 RID: 10217 RVA: 0x000E70F4 File Offset: 0x000E52F4
	public bool jh(object A_0)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			flag = dk2.b(this.a);
		}
		return flag ^ this.b;
	}

	// Token: 0x060027EA RID: 10218 RVA: 0x000E7128 File Offset: 0x000E5328
	public string ji()
	{
		return null;
	}

	// Token: 0x04001647 RID: 5703
	private string a;

	// Token: 0x04001648 RID: 5704
	private bool b;
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000236 RID: 566
[eiz("O")]
[Serializable]
public class bag : c7t, a9q, ISerializable
{
	// Token: 0x06000FE1 RID: 4065 RVA: 0x00041C38 File Offset: 0x0003FE38
	protected bag(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("O:I", typeof(Guid));
			this.b = A_0.GetString("O:N");
			this.c = A_0.GetByte("O:OC");
			this.d = A_0.GetInt64("O:OM");
			this.e = A_0.GetBoolean("O:E");
			return;
		}
		if (base.GetType() == typeof(bag))
		{
			this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.b = A_0.GetString("_Name");
			this.c = A_0.GetByte("_ObserverCode");
			this.d = A_0.GetInt64("_ObserverMask");
			this.e = A_0.GetBoolean("_Enabled");
			return;
		}
		this.a = (Guid)A_0.GetValue("Observer+_Id", typeof(Guid));
		this.b = A_0.GetString("Observer+_Name");
		this.c = A_0.GetByte("Observer+_ObserverCode");
		this.d = A_0.GetInt64("Observer+_ObserverMask");
		this.e = A_0.GetBoolean("Observer+_Enabled");
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00041DA0 File Offset: 0x0003FFA0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("O:I", this.a);
		info.AddValue("O:N", this.b);
		info.AddValue("O:OC", this.c);
		info.AddValue("O:OM", this.d);
		info.AddValue("O:E", this.e);
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00041E08 File Offset: 0x00040008
	public Guid qe()
	{
		return this.a;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00041E10 File Offset: 0x00040010
	public string y8()
	{
		return this.b;
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00041E18 File Offset: 0x00040018
	public bool a()
	{
		return this.e;
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00041E20 File Offset: 0x00040020
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00041E2C File Offset: 0x0004002C
	public bool b()
	{
		return true;
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00041E30 File Offset: 0x00040030
	public bag(string A_0, byte A_1)
	{
		czh.a(A_0, "name");
		if (A_1 > 64)
		{
			throw new ArgumentOutOfRangeException("observerCode", "Observer code must be a number between 0 and 64.");
		}
		this.a = Guid.NewGuid();
		this.b = A_0;
		this.c = A_1;
		this.d = bcj.a(new byte[]
		{
			this.c
		});
	}

	// Token: 0x04000954 RID: 2388
	private Guid a;

	// Token: 0x04000955 RID: 2389
	private string b;

	// Token: 0x04000956 RID: 2390
	public byte c;

	// Token: 0x04000957 RID: 2391
	public long d;

	// Token: 0x04000958 RID: 2392
	private bool e;
}

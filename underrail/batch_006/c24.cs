using System;
using System.Runtime.Serialization;

// Token: 0x020011DC RID: 4572
[eiz("MOT")]
[Serializable]
public sealed class c24 : ya, ISerializable
{
	// Token: 0x0600620F RID: 25103 RVA: 0x002A7C74 File Offset: 0x002A5E74
	private c24(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("MOT:R");
		this.b = A_0.GetString("MOT:M");
		this.c = (A_0.GetValue("MOT:V", typeof(float?)) as float?);
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x002A7CD8 File Offset: 0x002A5ED8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MOT:R", this.a);
		info.AddValue("MOT:M", this.b);
		info.AddValue("MOT:V", this.c);
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x002A7D28 File Offset: 0x002A5F28
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x002A7D30 File Offset: 0x002A5F30
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x002A7D3C File Offset: 0x002A5F3C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x002A7D44 File Offset: 0x002A5F44
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x002A7D50 File Offset: 0x002A5F50
	public float? c()
	{
		return this.c;
	}

	// Token: 0x06006216 RID: 25110 RVA: 0x002A7D58 File Offset: 0x002A5F58
	public void a(float? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006217 RID: 25111 RVA: 0x002A7D64 File Offset: 0x002A5F64
	public c24()
	{
	}

	// Token: 0x06006218 RID: 25112 RVA: 0x002A7D74 File Offset: 0x002A5F74
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.IsPlayer && c5x.Zone != null)
		{
			dvn dvn = new dvn(c5x.Zone.y8(), this.b);
			dvn.a(this.c);
			dvn.ym(null, null, null);
		}
	}

	// Token: 0x06006219 RID: 25113 RVA: 0x002A7DD8 File Offset: 0x002A5FD8
	protected override void pq(b0b A_0)
	{
		base.pq(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.IsPlayer && c5x.Zone != null)
		{
			new dvn(c5x.Zone.y8(), null).ym(null, null, null);
		}
	}

	// Token: 0x04002997 RID: 10647
	private bool a = true;

	// Token: 0x04002998 RID: 10648
	private string b;

	// Token: 0x04002999 RID: 10649
	private float? c;
}

using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011E5 RID: 4581
[eiz("ACX9")]
[Serializable]
public sealed class ed0 : ya, ISerializable, l2
{
	// Token: 0x0600624B RID: 25163 RVA: 0x002A8728 File Offset: 0x002A6928
	private ed0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("ACX9:E", typeof(EntityAspectReference<e11, e11>)) as EntityAspectReference<e11, e11>);
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x002A8754 File Offset: 0x002A6954
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ACX9:E", this.a);
	}

	// Token: 0x0600624D RID: 25165 RVA: 0x002A8770 File Offset: 0x002A6970
	public EntityAspectReference<e11, e11> a()
	{
		return this.a;
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x002A8778 File Offset: 0x002A6978
	public ed0(e11 A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<e11, e11>(A_0);
		}
	}

	// Token: 0x0600624F RID: 25167 RVA: 0x002A8794 File Offset: 0x002A6994
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<e11, e11>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x002A87E4 File Offset: 0x002A69E4
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x040029A5 RID: 10661
	private EntityAspectReference<e11, e11> a;
}

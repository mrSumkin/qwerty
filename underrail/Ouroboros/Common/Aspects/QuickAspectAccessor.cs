using System;
using System.Runtime.Serialization;

namespace Ouroboros.Common.Aspects
{
	// Token: 0x0200002A RID: 42
	[eiz("QAA")]
	[Serializable]
	public class QuickAspectAccessor<T> : ISerializable where T : cn7
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000473C File Offset: 0x0000293C
		public QuickAspectAccessor(cuw A_0)
		{
			czh.a(A_0, "container");
			this.a = A_0;
			this.a.act(new EventHandler<bdu>(this.a));
			this.a.acv(new EventHandler<bdu>(this.b));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004790 File Offset: 0x00002990
		private void b(object A_0, bdu A_1)
		{
			this.b = this.a.GetAspect<T>();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000047A4 File Offset: 0x000029A4
		private void a(object A_0, bdu A_1)
		{
			this.b = this.a.GetAspect<T>();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000047B8 File Offset: 0x000029B8
		protected QuickAspectAccessor(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (cuw)A_0.GetValue("QAA:C", typeof(cuw));
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000047E0 File Offset: 0x000029E0
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("QAA:C", this.a);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000047F4 File Offset: 0x000029F4
		public void b()
		{
			this.b = this.a.GetAspect<T>();
		}

		// Token: 0x04000132 RID: 306
		private cuw a;

		// Token: 0x04000133 RID: 307
		[NonSerialized]
		public T b;
	}
}

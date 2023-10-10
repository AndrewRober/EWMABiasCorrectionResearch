# Exploring the Impact of Beta on Exponentially Weighted Moving Average (EWMA) Performance: A Comparative Analysis

# Table of Contents

1. [Abstract](#abstract)
2. [Introduction](#introduction)
3. [Exponentially Weighted Moving Average and Beta](#exponentially-weighted-moving-average-and-beta)
4. [Bias Correction and Warm-Up Period](#bias-correction-and-warm-up-period)
5. [The Relationship Between Beta, Warm-Up Time, and Accuracy](#the-relationship-between-beta-warm-up-time-and-accuracy)
6. [The Effect of Different Beta Values on EWMA Behavior: Capturing Actual Data Curve and Overall Average](#the-effect-of-different-beta-values-on-ewma-behavior-capturing-actual-data-curve-and-overall-average)
7. [Memory Length and Common Beta Values](#memory-length-and-common-beta-values)
8. [Conclusion](#conclusion)
9. [Appendix: Relationship Between Beta Value and Gradient Descent](#appendix-relationship-between-beta-value-and-gradient-descent)

## Abstract
This research paper aims to explore the relationship between the beta value, warm-up period, and the accuracy of the Exponentially Weighted Moving Average (EWMA) technique. The objectives of this study are twofold: (1) to investigate how different beta values affect the EWMA curve's proximity to the actual average, and (2) to analyze the impact of beta values on different types of charts, particularly those with high rates of directional change and/or rapid overall changes. The findings provide insights into the selection of optimal beta values for specific series shapes and shed light on the behavior of the EWMA under different scenarios.

## Introduction
The Exponentially Weighted Moving Average (EWMA) is a widely used technique for smoothing time-series data. It calculates a weighted average of the data points, where the weightage decreases exponentially over time. The primary parameter influencing the behavior of the EWMA is the beta value. β (beta) determines the weight given to recent data points compared to historical data. By adjusting the beta value, we can control the responsiveness and smoothness of the EWMA curve.

## Exponentially Weighted Moving Average and Beta
The EWMA is defined by the equation:

$$  V_t = (1 - \beta) \cdot x_t + \beta \cdot V_{t-1}  $$

where ( V_t ) represents the EWMA at time ( t ), ( x_t ) is the current data point, and ( V_{t-1} ) is the previous EWMA value. The β (beta) value plays a crucial role in the calculation, as it determines the relative weight given to recent data points. *Higher beta values give more weight to recent observations, resulting in a more responsive EWMA curve.* In contrast, *lower beta values assign greater importance to historical data, leading to a smoother and slower response.* The selection of an appropriate beta value depends on the characteristics of the data and the desired trade-off between responsiveness and smoothness.

## Bias Correction and Warm-Up Period
The initial values of the EWMA can introduce bias and impact the accuracy of the estimates, particularly during the warm-up period. Bias correction techniques can be employed to address this issue. One commonly used approach is to modify the EWMA calculation formula to incorporate the bias correction factor. The bias-corrected EWMA equation is:

$$  V_t = \frac{V_t}{1 - \beta^{t}}  $$

This adjustment helps improve the accuracy of the EWMA, especially during the warm-up period when the EWMA is more susceptible to initial data points. Understanding the impact of bias correction and the warm-up period is crucial for obtaining reliable estimates from the EWMA and ensuring accurate representation of the underlying series.

![image](https://github.com/AndrewRober/EWMABiasCorrectionResearch/assets/54873972/cbc9630f-b49a-4181-a02b-b8f4cb5caaad)

## The Relationship Between Beta, Warm-Up Time, and Accuracy

The beta value in the Exponentially Weighted Moving Average (EWMA) plays a significant role in determining the warm-up time and accuracy of the estimation. A GIF is used to visually demonstrate the relationship between the beta value and the EWMA curve. When the beta value decreases, both the warm-up time and accuracy of the EWMA are affected.

Lowering the beta value results in a shorter warm-up time, especially when not using bias correction. This is because lower beta values assign less weight to recent data points, allowing the EWMA to adjust more quickly to changes in the underlying series. Consequently, the warm-up time decreases as the EWMA becomes more responsive to new data.

However, decreasing the beta value adversely affects the accuracy of the EWMA. When the beta value is smaller, the EWMA gives more weight to historical data, resulting in a smoother but slower response to changes in the series. As a result, the accuracy of the EWMA estimates decreases as the beta value decreases.

This observation holds true for both bias-corrected and non-bias-corrected EWMA calculations. The bias correction factor helps mitigate initial bias and enhances accuracy during the warm-up period. However, even with bias correction, decreasing the beta value reduces the responsiveness of the EWMA and leads to decreased accuracy.

In summary, the GIF visually illustrates how decreasing the beta value in the EWMA affects both the warm-up time and accuracy. While a lower beta value reduces the warm-up time, it also compromises the accuracy of the EWMA estimates, regardless of the presence of bias correction. Understanding this relationship is crucial for selecting an appropriate beta value that balances the desired responsiveness and accuracy in different scenarios.

![ezgif com-gif-maker](https://github.com/AndrewRober/EWMABiasCorrectionResearch/assets/54873972/8e15b63d-8d06-42c0-a600-e85dc676ea17)

# The Effect of Different Beta Values on EWMA Behavior: Capturing Actual Data Curve and Overall Average

The second objective of this research is to investigate the impact of different beta values on the behavior of the Exponentially Weighted Moving Average (EWMA) in capturing the actual data curve and the overall average curve. Higher beta values in the EWMA emphasize recent data points, enabling the moving average to respond quickly to changes and closely track exponential or exponential-like curves. Conversely, lower beta values assign greater importance to historical data, resulting in a smoother and slower response.

This behavior arises due to the weightage given to recent data points versus historical data points in the EWMA calculation. Higher beta values adapt the EWMA quickly to changes, closely following the shape of exponential or exponential-like curves. Increasing the beta value towards 1 reduces the responsiveness to recent data, causing the moving average to converge towards the overall average value and deviate from the individual points of the curve.

Additionally, decreasing the beta value has a similar effect to increasing the window size of the moving average, smoothing out the initial zeros and improving the estimation of the underlying curve when the data initially consists of mostly zeros or lower values.

The choice of the beta value depends on the specific characteristics of the data and the desired trade-off between responsiveness and smoothness. Experimentation with different beta values can help identify the most suitable value to accurately capture the desired behavior in a given application.

To visually demonstrate these behaviors, a GIF is provided, showcasing the EWMA curves with different beta values. The GIF reinforces the findings, illustrating how higher beta values align the EWMA closely with the actual data curve, while lower beta values trend towards the overall average curve.

![ezgif com-gif-maker (1)](https://github.com/AndrewRober/EWMABiasCorrectionResearch/assets/54873972/bd1ebf2e-04e3-4afc-89da-3af49736de51)

## Memory Length and Common Beta Values

The memory length of the Exponentially Weighted Moving Average (EWMA) can be approximated using the formula: memory = 1 / (1 - β), where β (beta) is the given value. This formula provides an estimation of the number of data points that significantly influence the EWMA calculation. Here are some common beta values and their corresponding memory lengths:

| Beta Value | Memory Length |
|------------|---------------|
| 0.9        | 10 points     |
| 0.98       | 50 points     |
| 0.99       | 100 points    |

These values are provided as a general guideline and can be adjusted based on the specific requirements and characteristics of the data.

## Conclusion

In conclusion, the selection of small or large beta values in the Exponentially Weighted Moving Average (EWMA) depends on the trade-off between responsiveness and smoothness. 

Using a small beta value (e.g., close to 0.9) in the EWMA provides a more responsive curve that quickly adapts to changes in the data. This can be beneficial for capturing rapid changes or short-term trends. However, a smaller beta value also leads to a shorter memory length, where the influence of past data diminishes more quickly. This may result in a higher level of noise and fluctuations in the EWMA curve, making it less suitable for capturing long-term trends or stable patterns.

On the other hand, using a large beta value (e.g., close to 1) in the EWMA results in a smoother curve that provides a longer memory length. The EWMA with a larger beta value is more suitable for capturing long-term trends and stable patterns. However, it may exhibit slower responses to rapid changes in the data.

It is essential to carefully select the beta value based on the specific characteristics of the data and the desired trade-off between responsiveness and smoothness. Additionally, considering the memory length associated with different beta values can provide insights into the influence of past data on the EWMA calculation.

Overall, understanding the effect of beta values on the EWMA curve's behavior and memory length allows practitioners to make informed decisions and select the appropriate beta value based on the specific requirements of their data analysis tasks.

## Appendix: Relationship Between Beta Value and Gradient Descent

In this appendix, we explore the relationship between the beta value in the Exponentially Weighted Moving Average (EWMA) and its connection to Gradient Descent. Understanding this relationship is crucial for leveraging the benefits of EWMA in the context of optimizing the learning process.

### Smoothing Effect and Slowing Oscillations

Choosing the appropriate beta value in EWMA can result in a smoothing effect and help mitigate rapid changes. This behavior is particularly relevant when utilizing EWMA in the context of Gradient Descent optimization algorithms, such as Gradient Descent with momentum.

The EWMA, with its ability to assign weights to recent data points, acts as a smoothing mechanism. It reduces the impact of sudden fluctuations in the gradients or parameter updates, leading to a more stable optimization process. By incorporating EWMA into Gradient Descent, specifically in the calculation of the moving average of the gradients (Vdw) and biases (Vdb), the optimization algorithm can mitigate the oscillations and achieve more consistent updates.

### Gradient Descent with Momentum Equations

To illustrate the integration of EWMA into Gradient Descent with momentum, we provide the equations for the forward propagation and backward propagation on a mini-batch, calculating Vdw, Vdb, and updating the weights (W) and biases (B):


$$
\begin{align*}
Z^{[l]} &= W^{[l]} \cdot A^{[l-1]} + b^{[l]} \\
A^{[l]} &= g^{[l]}(Z^{[l]}) \\
dZ^{[l]} &= dA^{[l]} \cdot g'^{[l]}(Z^{[l]}) \\
dW^{[l]} &= \frac{1}{m} \cdot dZ^{[l]} \cdot (A^{[l-1]})^T + \beta \cdot VdW^{[l-1]} \\
db^{[l]} &= \frac{1}{m} \cdot \sum(dZ^{[l]}, \text{axis}=1, \text{keepdims}=True) + \beta \cdot Vdb^{[l-1]} \\
VdW^{[l]} &= \beta \cdot VdW^{[l-1]} + (1 - \beta) \cdot dW^{[l]} \\
Vdb^{[l]} &= \beta \cdot Vdb^{[l-1]} + (1 - \beta) \cdot db^{[l]} \\
W^{[l]} &= W^{[l]} - \alpha \cdot VdW^{[l]} \\
B^{[l]} &= B^{[l]} - \alpha \cdot Vdb^{[l]}
\end{align*}
$$


In the above equations, the beta value (\(\beta\)) is used to control the weighting of the previous gradients (VdW and Vdb) in the calculation of the current gradients. The higher the beta value, the more emphasis is given to the previous gradients, resulting in a smoother optimization process.

Additionally, Gradient Descent with momentum becomes even more crucial when utilizing mini-batches in the training process. Mini-batches are randomly sampled subsets of the dataset used for each iteration of the optimization algorithm. While mini-batches provide computational efficiency and reduce the memory requirements compared to using the entire dataset (batch), they may not always fully represent the overall dataset.

In this context, the integration of EWMA into Gradient Descent with momentum becomes particularly beneficial. The EWMA allows for a more stable estimation of the gradients by smoothing out potential inconsistencies introduced by the mini-batches. By incorporating EWMA, the optimization algorithm can effectively mitigate the impact of noisy or biased gradients that may arise from using mini-batches, leading to more reliable and accurate updates of the model parameters. This results in improved convergence and better generalization performance.

While Gradient Descent with momentum also provides benefits when using the entire dataset (batch), its advantages are even more pronounced when dealing with mini-batches, making it a valuable technique for training machine learning models in scenarios where computational resources and memory are constrained.

This integration of EWMA and Gradient Descent provides an enhanced optimization technique that balances responsiveness and stability in the learning process.
